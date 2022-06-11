using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Employees
{
    public class Director : Employee
    {
        public Director(string cpf) : base(cpf, 5000) { }

        public override double GetBonification()
        {
            return EmployeeSalary * 0.5;
        }

        public override void GetAward()
        {
            this.EmployeeSalary *= 1.15; 
        }
    }
}