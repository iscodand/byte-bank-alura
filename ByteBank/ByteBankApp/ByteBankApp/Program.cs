using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankApp.Titular;
using ByteBankApp.BankAccounts;
using ByteBankApp.BankManagement;

AccountManager manager = new AccountManager();

Account account1 = new CheckingAccount("123-x", 123);
Account account2 = new SavingsAccount("456-x", 456);

manager.RegisterAccount(account1);
manager.RegisterAccount(account2);

Client client1 = new Client("987.987.987-98");
Client client2 = new Client("123.123.123-12");

Console.WriteLine(manager.GetTotalAccounts);

Console.ReadKey();