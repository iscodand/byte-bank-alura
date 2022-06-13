using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Employees;

namespace ByteBank_ADM.InternalSystem
{
    public abstract class AuthenticateUser : Employee
    {
        public AuthenticateUser(string cpf, double salary) : base(cpf, salary) { }

        public string InternalSystemPassword;
        public bool Authenticate(string password)
        {
            return this.InternalSystemPassword == password;
        }
    }
}
