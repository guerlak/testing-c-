using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        

        public static int numberOfEmployees { get; private set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
            Console.WriteLine("Creating an employee...");
            numberOfEmployees++;
        }

        public Employee(string email)
        {
            Email = email;
        }

        public static int getNumberOfEmplyees()
        {
            return numberOfEmployees;
        }

        public virtual double GetBonus()
        {
            return Salary * 0.10;
        }

        public abstract void IncreaseSalary();
    }

}

