using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.AgencySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Rafael Leite", "09851411-22", "guerlak@hotmail.com");
            
            BankAccount bradesco = new BankAccount(c1, "2134-9", 111000.00);
            BankAccount itau = new BankAccount(c1, "2134-9", 1000.00);

            bradesco.MakeTransfer(itau, 10000.00);

            Console.WriteLine(itau.Amount);

            Console.ReadLine();

        }
    }
}
