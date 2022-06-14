using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankApp.Titular;

namespace ByteBankApp.BankAccounts
{
    public abstract class Account
    {
        public Client AccountTitular { get; set; }

        private string accountName;
        public string AccountName {
            get { return accountName; }
            protected set
            {
                if (value == null)
                {
                    Console.WriteLine("Nome da Conta não pode estar vazio!");
                }
                else
                {
                    accountName = value;
                }
            }
        }

        public double AccountBalance { get; private set; }

        public double AccountLimit { get; set; }

        public string AgencyName { get; set; }

        private int agencyNumber;
        public int AgencyNumber
        {
            get { return agencyNumber; }
            protected set
            {
                if (value <= 0)
                {
                    Console.WriteLine("A conta não pode ser menor ou igual a zero!");
                }
                else
                {
                    agencyNumber = value;
                }
            }
        }

        public Account(string accName, int agcNumber, double accLimit)
        {
            AccountName = accName;
            AgencyNumber = agcNumber;
            AccountLimit = accLimit;

            TotalAccounts += 1;
        }

        public static int TotalAccounts { get ; set; }

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
                Console.WriteLine("Saque Indisponível!");
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