using System;
using ByteBankApp.Titular;

namespace ByteBankApp.BankAccounts
{
    public class Account
    {
        public Client AccountTitular { get; set; }

        private string accountName;
        public string AccountName {
            get { return accountName; }
            set
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

        private double accountBalance;
        public double AccountBalance
        {
            get { return accountBalance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Saldo não pode ser menor que zero!");
                }
                else
                {
                    accountBalance = value;
                }
            }
        }

        private double accountLimit = 1500;
        public double AccountLimit
        {
            get { return accountLimit; }
        }

        public string AgencyName { get; set; }

        private int agencyNumber;
        public int AgencyNumber
        {
            get { return agencyNumber; }
            set
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

        public Account(string accName, int accNumber)
        {
            AccountName = accName;
            AgencyNumber = accNumber;
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