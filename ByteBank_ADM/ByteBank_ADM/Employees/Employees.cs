using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Utilitaries;

namespace ByteBank_ADM.Employees
{
    public class Employee
    {
        // id = 0 --> Diretor
        // id = 1 --> Funcionário Comum
        // id = 2 --> Dev

        // private int employeeId;

        public string EmployeeName { get; set; }
        public string EmployeeCPF { get; set; }
        public double EmployeeSalary { get; set; }

        public virtual double GetBonification()
        {
            return EmployeeSalary * 0.1;
        }

        public virtual double GetAward()
        {
            return EmployeeSalary * 0.2;
        }
    }
}
