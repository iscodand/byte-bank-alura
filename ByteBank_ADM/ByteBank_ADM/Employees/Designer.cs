using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Employees
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(cpf, 3000) { }

        public override double GetBonification()
        {
            return EmployeeSalary * 0.17;
        }

        public override void GetAward()
        {
            this.EmployeeSalary *= 1.11;
        }
    }
}
