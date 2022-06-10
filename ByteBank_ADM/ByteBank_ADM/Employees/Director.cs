using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank_ADM.Employees
{
    public class Director : Employee
    {
        public override double GetBonification()
        {
            return EmployeeSalary;
        }

        public override double GetAward()
        {
            return EmployeeSalary + base.GetAward(); 
        }
    }
}
