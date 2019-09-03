using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Exceptions
{
    class InsufficientFundsException : FinanceOperationsException
    {
        public double Amount { get; }
        public double WithdrawValue { get; }

        public InsufficientFundsException()
        {

        }

        public InsufficientFundsException(string message) : base(message)
        {
     
        }

        public InsufficientFundsException(double amount, double withdrawValue) : this("Attempt to withdraw " + withdrawValue + " with insufficient funds." + " - Actual funds: " + amount)
        {
            Amount = amount;
            WithdrawValue = withdrawValue;
        }
    }
}
