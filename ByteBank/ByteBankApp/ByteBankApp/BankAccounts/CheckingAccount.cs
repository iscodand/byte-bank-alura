﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankApp.BankAccounts
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string accName, int agcNumber) : base(accName, agcNumber, 2000) { }
    }
}