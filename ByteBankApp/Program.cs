using System;
using ByteBankApp.Titular;
using ByteBankApp.BankAccounts;

Account account1 = new Account("123-x", 123);
Account account2 = new CheckingAccount("456-x", 456);

Console.WriteLine(Account.TotalAccounts);

Client client1 = new Client();
Client client2 = new Client();

Console.WriteLine(account1.AccountLimit);
Console.WriteLine(account2.AccountLimit);

Console.ReadKey();