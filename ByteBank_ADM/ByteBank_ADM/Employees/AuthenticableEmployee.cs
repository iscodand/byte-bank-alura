using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.InternalSystem;

namespace ByteBank_ADM.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticateUser
    {
        protected AuthenticableEmployee(string cpf, double salary) : base(cpf, salary) { }

        public string InternalSystemLogin { get; set; }
        public string InternalSystemPassword { get; set; }

        public bool Authenticate(string login, string password)
        {
            return this.InternalSystemLogin == login && this.InternalSystemPassword == password;
        }

        public override void GetAward()
        {
            throw new NotImplementedException();
        }

        public override double GetBonification()
        {
            throw new NotImplementedException();
        }
    }
}
