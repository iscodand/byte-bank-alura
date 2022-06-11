﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Employees
{
    public class Operator : Employee
    {
        public Operator(string cpf) : base(cpf, 2000) { }

        public override double GetBonification()
        {
            return EmployeeSalary * 0.10;
        }

        public override void GetAward()
        {
            this.EmployeeSalary *= 1.15;
        }
    }
}
