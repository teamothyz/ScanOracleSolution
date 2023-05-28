namespace OracleScan.Models
{
    public class Account
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Tenant { get; set; }

        public Account(string email, string password, string tenant)
        {
            Email = email;
            Password = password;
            Tenant = tenant;
        }
    }
}
