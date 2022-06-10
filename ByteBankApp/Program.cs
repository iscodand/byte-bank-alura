using System;
using bytebank.Titular;
using bytebank.Account;

Account account1 = new Account("123-x", 123);
Account account2 = new Account("456-x", 456);

Console.WriteLine(Account.TotalAccounts);

Client client1 = new Client();
Client client2 = new Client();

Console.WriteLine(Account.TotalAccounts);

Console.ReadKey();