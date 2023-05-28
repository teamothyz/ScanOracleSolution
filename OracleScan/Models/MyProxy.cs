namespace OracleScan.Models
{
    public class MyProxy
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public MyProxy(string host, int port) 
        {
            Host = host;
            Port = port;
            UserName = null;
            Password = null;
        }

        public MyProxy(string host, int port, string username, string password)
        {
            Host = host;
            Port = port;
            UserName = username;
            Password = password;
        }
    }
}
