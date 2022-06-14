using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SystemManager;

namespace ByteBank_ADM.Employees
{
    public class AccountManager : AuthenticableEmployee, ISalaryManager
    {
        public AccountManager(string cpf) : base(cpf, 4000) { }


        public double GetBonification()
        {
            return EmployeeSalary * 0.2;
        }

        public void GetAward()
        {
            this.EmployeeSalary *= 1.05;
        }
    }
}
