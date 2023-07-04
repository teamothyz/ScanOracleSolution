using OracleScan.Models;

namespace OracleScan.Services
{
    public class DataHandler
    {
        private static readonly object _lockAccount = new();
        private static readonly object _lockProxy = new();
        private static readonly object _lockLogs = new();
        private static readonly object _lockSuccess = new();
        private static readonly object _lockFailed = new();
        private static readonly object _lockError = new();
        private static readonly object _lockBan = new();

        private static readonly object _lockBanProxy = new();
        private static readonly object _lockErrorProxy = new();

        public static Queue<Account> LoadAccounts(string path)
        {
            var accounts = new Queue<Account>();
            lock (_lockAccount)
            {
                try
                {
                    using var reader = new StreamReader(path);
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            var details = line.Split(":");
                            if (!details[0].Contains('@')) continue;
                            var account = new Account(details[0], details[1], details[0].Split("@")[0]);
                            accounts.Enqueue(account);
                        }
                        catch
                        {
                            WriteLog($"[LoadAccounts] Got exception when loading account: {line}");
                        }
                        finally
                        {
                            line = reader.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    WriteLog($"[LoadAccounts] Got exception when loading accounts. Error: {ex}");
                }
            }
            return accounts;
        }

        public static List<MyProxy> LoadProxies(string path)
        {
            var proxies = new List<MyProxy>();
            lock (_lockProxy)
            {
                try
                {
                    using var reader = new StreamReader(path);
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            var details = line.Split(":");
                            if (details.Length == 2)
                            {
                                var proxy = new MyProxy(details[0], int.Parse(details[1]));
                                proxies.Add(proxy);
                            }
                            else if (details.Length == 4)
                            {
                                var proxy = new MyProxy(details[0], int.Parse(details[1]), details[2], details[3]);
                                proxies.Add(proxy);
                            }
                            else WriteLog($"[LoadAccounts] Got exception when loading proxy: {line}");
                        }
                        catch
                        {
                            WriteLog($"[LoadAccounts] Got exception when loading proxy: {line}");
                        }
                        line = reader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    WriteLog($"[LoadProxies] Got exception when loading proxies. Error: {ex}");
                }
            }
            return proxies;
        }

        public static void WriteLog(string message)
        {
            lock (_lockLogs)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "output");
                    var logPath = Path.Combine(outputPath, "logs");
                    var logFile = Path.Combine(logPath, $"{DateTime.Now:ddMMyyyy}log.txt");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(logPath)) Directory.CreateDirectory(logPath);

                    using var writer = new StreamWriter(logFile, true);
                    writer.WriteLine($"{DateTime.Now:HH:mm:ss} {message}");
                    writer.Flush();
                    writer.Close();
                }
                catch { }
            }
        }

        public static void WriteSuccess(Account account)
        {
            lock (_lockSuccess)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "output");
                    var successPath = Path.Combine(outputPath, "success");
                    var successFile = Path.Combine(successPath, $"{DateTime.Now:ddMMyyyy}success.txt");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(successPath)) Directory.CreateDirectory(successPath);

                    using var writer = new StreamWriter(successFile, true);
                    writer.WriteLine($"{account.Email}:{account.Password}");
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog($"[WriteSuccess] Got exception when writing success data. Error: {ex}");
                }
            }
        }

        public static void WriteBanProxy(MyProxy proxy)
        {
            lock (_lockBanProxy)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "proxy");
                    var banPath = Path.Combine(outputPath, "ban");
                    var banFile = Path.Combine(banPath, $"{DateTime.Now:ddMMyyyy}ban.txt");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(banPath)) Directory.CreateDirectory(banPath);

                    using var writer = new StreamWriter(banFile, true);
                    if (string.IsNullOrEmpty(proxy.UserName))
                    {
                        writer.WriteLine($"{proxy.Host}:{proxy.Port}");
                    }
                    else
                    {
                        writer.WriteLine($"{proxy.Host}:{proxy.Port}:{proxy.UserName}:{proxy.Password}");
                    }
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog($"[WriteBanProxy] Got exception when writing ban proxy. Error: {ex}");
                }
            }
        }

        public static void WriteErrorProxy(MyProxy proxy)
        {
            lock (_lockErrorProxy)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "proxy");
                    var diePath = Path.Combine(outputPath, "die");
                    var dieFile = Path.Combine(diePath, $"{DateTime.Now:ddMMyyyy}die.txt");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(diePath)) Directory.CreateDirectory(diePath);

                    using var writer = new StreamWriter(dieFile, true);
                    if (string.IsNullOrEmpty(proxy.UserName))
                    {
                        writer.WriteLine($"{proxy.Host}:{proxy.Port}");
                    }
                    else
                    {
                        writer.WriteLine($"{proxy.Host}:{proxy.Port}:{proxy.UserName}:{proxy.Password}");
                    }
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog($"[WriteErrorProxy] Got exception when writing die proxy. Error: {ex}");
                }
            }
        }

        public static void WriteFailed(Account account)
        {
            lock (_lockFailed)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "output");
                    var failedPath = Path.Combine(outputPath, "failed");
                    var failedFile = Path.Combine(failedPath, $"{DateTime.Now:ddMMyyyy}failed.txt");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(failedPath)) Directory.CreateDirectory(failedPath);

                    using var writer = new StreamWriter(failedFile, true);
                    writer.WriteLine($"{account.Email}:{account.Password}");
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog($"[WriteFailed] Got exception when writing failed data. Error: {ex}");
                }
            }
        }

        public static void WriteError(Account account)
        {
            lock (_lockError)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "output");
                    var failedPath = Path.Combine(outputPath, "error");
                    var failedFile = Path.Combine(failedPath, $"{DateTime.Now:ddMMyyyy}error.txt");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(failedPath)) Directory.CreateDirectory(failedPath);

                    using var writer = new StreamWriter(failedFile, true);
                    writer.WriteLine($"{account.Email}:{account.Password}");
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog($"[WriteFailed] Got exception when writing error data. Error: {ex}");
                }
            }
        }

        public static void WriteBan(Account account)
        {
            lock (_lockBan)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "output");
                    var failedPath = Path.Combine(outputPath, "ban");
                    var failedFile = Path.Combine(failedPath, $"{DateTime.Now:ddMMyyyy}ban.txt");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(failedPath)) Directory.CreateDirectory(failedPath);

                    using var writer = new StreamWriter(failedFile, true);
                    writer.WriteLine($"{account.Email}:{account.Password}");
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog($"[WriteBan] Got exception when writing ban data. Error: {ex}");
                }
            }
        }

        public static void WriteLastRun(string filename, int scanned)
        {
            lock (_lockError)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var outputPath = Path.Combine(basePath, "output");
                    var scannedPath = Path.Combine(outputPath, "scanned");
                    var scannedFile = Path.Combine(scannedPath, $"{DateTime.Now:dd-MM-yyyy}_{DateTime.Now:HH-mm-ss}_{scanned}_{filename}");

                    if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                    if (!Directory.Exists(scannedPath)) Directory.CreateDirectory(scannedPath);
                    File.Create(scannedFile).Close();
                }
                catch (Exception ex)
                {
                    WriteLog($"[WriteFailed] Got exception when writing scanned data. Error: {ex}");
                }
            }
        }
    }
}
