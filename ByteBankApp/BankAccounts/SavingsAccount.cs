using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankApp.BankAccounts
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string accName, int agcNumber) : base(accName, agcNumber, 3000) { }
    }
}
