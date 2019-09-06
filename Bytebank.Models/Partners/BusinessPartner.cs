

using ByteBank.Employees.Tools;
using System;

namespace ByteBank.Partners
{
    public class BusinessPartner : IAuth
    {
        public string CompanyName { get; }
        private string password;
        private AuthenticationHelper helper = new AuthenticationHelper();

        public BusinessPartner(string companyName, string password)
        {
            CompanyName = companyName;
            this.password = password;
        }

     

        public bool DoAuthentication(string password)
        {
            if(helper.ComparePasswords(this.password, password))
            {
                Console.WriteLine("Auth success");
            }
            else
            {
                Console.WriteLine("Auth failed");
            }
            return helper.ComparePasswords(this.password, password);
        }

    }
}


