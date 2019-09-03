using ByteBank.Employees.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Employees
{
    public abstract class AuthEmployee : Employee, IAuth
    {
        public string Password { get; set; }

        public AuthEmployee(string name, string email, double salary) : base(name, email, salary)
        {
        }

        public bool DoAuthentication(string password)
        {
            return Password == password;
        }

        public string ShowCompanyName()
        {
            throw new NotImplementedException();
        }
    }
}
