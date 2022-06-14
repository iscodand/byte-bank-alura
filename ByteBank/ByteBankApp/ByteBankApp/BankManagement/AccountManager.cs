using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankApp.BankAccounts;

namespace ByteBankApp.BankManagement
{
    public class AccountManager
    {
        private int TotalAccounts;

        public void RegisterAccount(Account account)
        {
            this.TotalAccounts++;
        }

        public int GetTotalAccounts()
        {
            return this.TotalAccounts;
        }
    }
}
