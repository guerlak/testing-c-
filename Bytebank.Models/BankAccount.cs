using ByteBank.Exceptions;
using System;

namespace ByteBank
{
    public class BankAccount
    {
        public Customer Customer { get; private set; }
        public static int TotalAccounts { get; private set; }
        public static double OperationTax { get; private set; }
        public string AccountNumber { get; private set; }
        private double amount;
        private int notPermitteWithdraw;
        
        public double Amount 
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value under than zero");
}
                else
                {
                    amount = value;
                }
            }
        }

        public BankAccount(Customer customer, string accountNumber, double amount)
        {
            if (customer != null)
            {
                if (accountNumber.Length < 4 || amount < 1)
                {
                    throw new ArgumentException("One or more inputs to set the new account is wrong.", "Testing Param");
                }
                Customer = customer;
                AccountNumber = accountNumber;
                Amount = amount;
                TotalAccounts++;
                CalcOperationTax();
            }
            else
            {
                throw new ArgumentException("No customer created: " +nameof(customer));
            } 
        }

        private void CalcOperationTax()
        {
            try
            {
                OperationTax = 30 / TotalAccounts;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void MakeDeposit(double value)
        {
            Amount += value;
        }

        public void WithDraw(double value)
        {
            if(value < 0)
            {
                throw new ArgumentException("Withdraw Value under zero: " + value + " " + notPermitteWithdraw);
            }

            if (value < Amount)
            {
                Amount -= value;
            }
            else
            {
                notPermitteWithdraw++;
                throw new InsufficientFundsException(Amount, value);
            }
        }

        public void  MakeTransfer(BankAccount bankAcc, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Withdraw Value under zero: " + value);
            }

                try
                {
                    WithDraw(value);
                    bankAcc.MakeDeposit(value);
                }
                catch(InsufficientFundsException e)
                {
                    notPermitteWithdraw++;
                //using just throw with no declaration prop to get the Withdraw method under execution in program
                //throw;
                throw new FinanceOperationsException("Operation failed.", e);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
               
        }

    }

}