using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankApp.BankAccounts
{
    public class CheckingAccount : Account
    {
        private double accountLimit;
        public new double AccountLimit
        {
            get { return accountLimit;  }
            set { accountLimit = value; }
        }

        public CheckingAccount(string accName, int accNumber) : base(accName, accNumber) {   }
    }
}