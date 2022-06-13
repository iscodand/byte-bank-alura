using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Utilitaries;

namespace ByteBank_ADM.Employees
{
    public abstract class Employee
    {
        public static int totalEmployees { get; private set; }

        public Employee(string cpf, double salary)
        {
            this.EmployeeCPF = cpf;
            this.EmployeeSalary = salary;

            Console.WriteLine("Criando um Funcionário!");
            totalEmployees++;
        }

        public string EmployeeName { get; set; }

        public string EmployeeCPF { get; private set; }

        public double EmployeeSalary { get; protected set; }

        public abstract double GetBonification();
        public abstract void GetAward();
    }
}