using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Employees
{
    class Designer : Employee
    {
        public Designer(string name, string email, double salary) : base(name, email, salary)
        {
            Console.WriteLine("Creating Designer...");
        }

        public override double GetBonus()
        {
            return Salary * 0.30;
        }

        public override void IncreaseSalary()
        {
            Salary += Salary * 0.15;
        }
    }
}
