﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.InternalSystem;

namespace ByteBank_ADM.Employees
{
    public class Director : AuthenticateUser
    {
        public Director(string cpf) : base(cpf, 5000) { }

        public override double GetBonification()
        {
            return EmployeeSalary * 0.5;
        }

        public override void GetAward()
        {
            this.EmployeeSalary *= 1.15; 
        }
    }
}