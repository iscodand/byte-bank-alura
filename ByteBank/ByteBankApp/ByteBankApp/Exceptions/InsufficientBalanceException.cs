using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankApp.Exceptions
{
    public class InsufficientBalanceException : FinancialOperationException
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }
}
