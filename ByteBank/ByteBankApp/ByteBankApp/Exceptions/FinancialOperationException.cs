using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankApp.Exceptions
{
    public class FinancialOperationException : Exception
    {
        public FinancialOperationException() : base() { }

        public FinancialOperationException(string message) : base(message) { }

        public FinancialOperationException(string message, Exception inner) : base(message, inner) { }

        protected FinancialOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
