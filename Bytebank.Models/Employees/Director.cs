using ByteBank.Employees.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    class Director : Employee
    {
        public Director(string name, string email, double salary) : base(name, email, salary)
        {
            Console.WriteLine("Creating director.");
        }

        public override double GetBonus()
        {
            //Adding bonus of the base class using the base syntax
            return Salary + base.GetBonus();
        }

         internal protected override void IncreaseSalary()
        {
            Salary += Salary * 0.5;
        }

       

    }

}
