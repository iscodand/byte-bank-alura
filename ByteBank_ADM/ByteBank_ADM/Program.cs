using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Employees;
using ByteBank_ADM.Utilitaries;

Console.WriteLine("Boas Vindas ao ByteBank ADM!");

BonificationManager manager = new BonificationManager();

Operator operator1 = new Operator("12345678901");
operator1.EmployeeName = "Isco";

Director director1 = new Director("987654321");
director1.EmployeeName = "JV";

Designer designer1 = new Designer("34763473423");
designer1.EmployeeName = "Gui";

AccountManager accmanager1 = new AccountManager("51231232323");
accmanager1.EmployeeName = "Roberto";

manager.Register(operator1);
manager.Register(director1);
manager.Register(designer1);
manager.Register(accmanager1);

Console.WriteLine(operator1.EmployeeSalary);
Console.WriteLine(director1.EmployeeSalary);
Console.WriteLine(designer1.EmployeeSalary);
Console.WriteLine(accmanager1.EmployeeSalary);

Console.ReadKey();
