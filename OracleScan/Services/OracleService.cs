using OracleScan.Models;
using System.Net;
using System.Security.Principal;

namespace OracleScan.Services
{
    public class OracleService
    {
        private static readonly List<string> _userAgents = new()
        {
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36 Edg/113.0.1774.57",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu Chromium/37.0.2062.94 Chrome/37.0.2062.94 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/600.8.9 (KHTML, like Gecko) Version/8.0.8 Safari/600.8.9",
            "Mozilla/5.0 (iPad; CPU OS 8_4_1 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12H321 Safari/600.1.4",
            "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.10240",
            "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:40.0) Gecko/20100101 Firefox/40.0",
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:40.0) Gecko/20100101 Firefox/40.0",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_4) AppleWebKit/600.7.12 (KHTML, like Gecko) Version/8.0.7 Safari/600.7.12",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_5) AppleWebKit/600.8.9 (KHTML, like Gecko) Version/7.1.8 Safari/537.85.17",
            "Mozilla/5.0 (iPad; CPU OS 8_4 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12H143 Safari/600.1.4",
            "Mozilla/5.0 (iPad; CPU OS 8_3 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12F69 Safari/600.1.4",
            "Mozilla/5.0 (Windows NT 6.1; rv:40.0) Gecko/20100101 Firefox/40.0",
            "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36"
        };

        public static HttpClient CreateClient(MyProxy? myProxy, ProxyType type)
        {
            var handler = new HttpClientHandler();
            if (myProxy != null && type != ProxyType.None)
            {
                var webProxy = new WebProxy($"{type}://{myProxy.Host}:{myProxy.Port}");
                if (!string.IsNullOrEmpty(myProxy.UserName) && !string.IsNullOrEmpty(myProxy.Password))
                {
                    var credential = new NetworkCredential
                    {
                        UserName = myProxy.UserName,
                        Password = myProxy.Password
                    };
                    webProxy.Credentials = credential;
                }
                handler.Proxy = webProxy;
                handler.UseProxy = true;
            }
            handler.UseCookies = false;
            return new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(60)
            };
        }

        public static async Task<HttpStatusCode> CheckTenant(HttpClient client, Account account, CancellationToken token)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Origin", "https://www.oracle.com");
                client.DefaultRequestHeaders.Add("Referer", "https://www.oracle.com/cloud/sign-in.html?redirect_uri=https%3A%2F%2Fcloud.oracle.com%2F");
                client.DefaultRequestHeaders.Add("User-Agent", GetUserAgent());
                var url = $"https://login.oci.oraclecloud.com/v2/cloudAccount?tenant={account.Tenant}";
                var res = await client.GetAsync(url, token);
                if (res.StatusCode == HttpStatusCode.OK) DataHandler.WriteSuccess(account);
                if (res.StatusCode == HttpStatusCode.Forbidden) DataHandler.WriteBan(account);
                if (res.StatusCode == HttpStatusCode.NotFound) DataHandler.WriteError(account);
                return res.StatusCode;
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog($"[CheckTenant] Got exception while checking tenant {account.Tenant}. Error: {ex}");
                DataHandler.WriteError(account);
                return HttpStatusCode.Gone;
            }
        }

        private static string GetUserAgent()
        {
            var rand = new Random();
            return _userAgents[rand.Next(0, _userAgents.Count - 1)];
        }
    }
}
