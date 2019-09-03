

using ByteBank.Employees.Tools;
using System;

namespace ByteBank.Partners
{
    public class BusinessPartner : IAuth
    {
        private string CompanyName;
        private string password;

        public BusinessPartner(string companyName, string password)
        {
            CompanyName = companyName;
            this.password = password;
        }

        public bool DoAuthentication(string password)
        {
            return this.password == password;
        }

        public string ShowCompanyName()
        {
            return CompanyName;
        }
    }
}


