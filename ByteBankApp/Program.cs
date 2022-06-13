using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankApp.Titular;
using ByteBankApp.BankAccounts;

Account account1 = new CheckingAccount("123-x", 123);
Account account2 = new SavingsAccount("456-x", 456);

Client client1 = new Client("987.987.987-98");
Client client2 = new Client("123.123.123-12");

Console.WriteLine(Account.TotalAccounts);

Console.WriteLine(account1.AccountLimit);
Console.WriteLine(account2.AccountLimit);

Console.ReadKey();