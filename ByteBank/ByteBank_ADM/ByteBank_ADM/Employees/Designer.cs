using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SystemManager;

namespace ByteBank_ADM.Employees
{
    public class Designer : Employee, ISalaryManager
    {
        public Designer(string cpf) : base(cpf, 3000) { }

        public double GetBonification()
        {
            return EmployeeSalary * 0.17;
        }

        public void GetAward()
        {
            this.EmployeeSalary *= 1.11;
        }
    }
}
