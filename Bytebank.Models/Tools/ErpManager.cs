using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Employees.Tools
{
    class ErpManager
    {
        public bool Login(IAuth authEmployee, string password)
        {
            bool isAuthenticate = authEmployee.DoAuthentication(password);
            string name = authEmployee.ShowCompanyName();

            if (isAuthenticate)
            {
                Console.WriteLine("Welcome to the ERP system :)");
                Console.WriteLine("Employee: " + authEmployee.ShowCompanyName());
                return true;
            }
            else
            {
                Console.WriteLine("Wrong password :(");
                return false;
            }
        }

        
    }
}
