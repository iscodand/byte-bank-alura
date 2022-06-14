using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankApp.BankManagement;
using ByteBankApp.Titular;
using ByteBankApp.BankAccounts;
using ByteBankApp.Exceptions;

Account account1 = new CheckingAccount("123-x", 123);
Account account2 = new SavingsAccount("456-x", 456);

account1.RegisterAccount(account1);
account2.RegisterAccount(account2);

Client client1 = new Client("987.987.987-98");
Client client2 = new Client("123.123.123-12");

try
{
    account1.Deposit(50);
    account1.Withdraw(200);
}
catch(InsufficientBalanceException ex)
{
    Console.WriteLine("Ops! Ocorreu um erro do tipo InsufficientBalanceException");
}

Console.WriteLine(account1.AccountBalance);

Console.WriteLine(account2.AccountLimit);
Console.WriteLine(account1.AccountLimit);

Console.ReadKey();