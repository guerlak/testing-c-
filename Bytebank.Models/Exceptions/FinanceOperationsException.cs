using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Exceptions
{
   public class FinanceOperationsException : Exception
    {
        public FinanceOperationsException()
        {
        }

        public FinanceOperationsException(string message) 
            : base(message)
        {
        }

        public FinanceOperationsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
