using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankApp.Titular;
using ByteBankApp.Exceptions;

namespace ByteBankApp.BankAccounts
{
    public abstract class Account
    {
        public Client AccountTitular { get; set; }
        public string AccountName { get; }

        private double _accountBalance = 100;
        public double AccountBalance 
        {
            get { return _accountBalance; }
            private set { _accountBalance = value;  }
        }

        public double AccountLimit { get; protected set; }
        public string AgencyName { get; set; }
        public int AgencyNumber { get; }


        public Account(string accName, int agcNumber, double accLimit)
        {
            AccountName = accName;
            AgencyNumber = agcNumber;
            AccountLimit = accLimit;

            // OperatingTax = 30 / TotalAccounts;

            TotalAccounts++;
        }

        // Refatorar Código
        public static double OperatingTax { get; private set; }

        private int TotalAccounts;

        public void RegisterAccount(Account account)
        {
            this.TotalAccounts++;
        }

        public int GetTotalAccounts()
        {
            return this.TotalAccounts;
        }

        // Operações Bancárias
        private bool WithdrawDisponible(double value)
        {
            if (AccountBalance < value)
            {
                return false;
            }
            else if (value < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Withdraw(double value)
        {
            if (WithdrawDisponible(value) == true)
            {
                AccountBalance = AccountBalance - value;
                Console.WriteLine("Saque Realizado!");
                Console.WriteLine($"- R$ {value} -- {AccountTitular}");
            }
            else
            {
                throw new InsufficientBalanceException(); 
            }
        }

        public void Deposit(double value)
        {
            if (AccountBalance + value < AccountLimit)
            {
                Console.WriteLine("Depósito Realizado!");
                AccountBalance = AccountBalance + value;
                Console.WriteLine($"+ R$ {value} -- {AccountTitular}");
            }
            else
            {
                Console.WriteLine("Depósito Indisponível!");
            }
        }

        public void TranferMoney(double value, Account destiny)
        {
            if (WithdrawDisponible(value) == true)
            {
                AccountBalance = AccountBalance - value;
                destiny.AccountBalance = destiny.AccountBalance + value;

                Console.WriteLine("Transferência Realizada com Sucesso!");
                Console.WriteLine($"+ R$ {value} -- {destiny.AccountBalance}");
            }
            else
            {
                Console.WriteLine("Transferência Malsucedida!");

            }
        }
    }
}