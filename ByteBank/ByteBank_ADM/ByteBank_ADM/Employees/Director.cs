using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SystemManager;

namespace ByteBank_ADM.Employees
{
    public class Director : AuthenticableEmployee, ISalaryManager
    {
        public Director(string cpf) : base(cpf, 5000) { }

        public double GetBonification()
        {
            return EmployeeSalary * 0.5;
        }

        public void GetAward()
        {
            this.EmployeeSalary *= 1.15; 
        }
    }
}