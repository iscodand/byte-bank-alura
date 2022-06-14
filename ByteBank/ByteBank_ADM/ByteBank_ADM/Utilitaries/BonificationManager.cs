using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Employees;

namespace ByteBank_ADM.Utilitaries
{
    interface IBonificationManager
    {
        public void Register(Employee employee);
        public double GetTotalBonification();
    }
}
