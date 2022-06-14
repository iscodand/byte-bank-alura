using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SystemManager;

namespace ByteBank_ADM.Employees
{
    public class Operator : Employee, ISalaryManager
    {
        public Operator(string cpf) : base(cpf, 2000) { }

        public double GetBonification()
        {
            return EmployeeSalary * 0.10;
        }

        public void GetAward()
        {
            this.EmployeeSalary *= 1.15;
        }
    }
}
