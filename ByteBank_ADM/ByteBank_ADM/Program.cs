using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Employees;
using ByteBank_ADM.Utilitaries;

Console.WriteLine("Boas Vindas ao ByteBank ADM!");

BonificationManager manager = new BonificationManager();

Employee employee1 = new Operator();
employee1.EmployeeName = "Isco";
employee1.EmployeeCPF = "1234567890-1";
employee1.EmployeeSalary = 1200;

Employee director1 = new Director();
director1.EmployeeName = "JV";
director1.EmployeeCPF = "1234567890-2";
director1.EmployeeSalary = 3000;

manager.Register(director1);
manager.Register(employee1);

employee1.GetBonification();
director1.GetBonification();

Console.WriteLine(manager.GetTotalBonification());


Console.ReadKey();
