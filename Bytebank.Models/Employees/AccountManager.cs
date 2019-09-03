using ByteBank.Employees.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Employees
{
    class AccountManager : AuthEmployee
    {
        public AccountManager(string name, string email, double salary) : base(name, email, salary)
        {
            Console.WriteLine("Creating Account Manager...");
        }

        public override double GetBonus()
        {
            return Salary * 0.25;
        }

        public override void IncreaseSalary()
        {
            Salary *= 0.25;
        }

    }
}
