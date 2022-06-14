using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Employees;

namespace ByteBank_ADM.SystemManager
{
    public interface ISalaryManager
    {
        public double GetBonification();
        public void GetAward();
    }
}
