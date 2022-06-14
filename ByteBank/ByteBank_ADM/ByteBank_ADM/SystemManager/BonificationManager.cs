using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Employees;

namespace ByteBank_ADM.SystemManager
{
    public class BonificationManager
    {
        private double totalBonification;

        public void Register(Employee employee)
        {
            this.totalBonification += employee.GetBonification();
        }

        public double GetTotalBonification()
        {
            return this.totalBonification;
        }
    }
}
