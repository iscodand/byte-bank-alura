using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Employees;

namespace ByteBank_ADM.InternalSystem
{
    public class InternalSystem
    {
        public bool Login(AuthenticateUser user, string password)
        {

            bool AuthenticateUser = user.Authenticate(password);

            if (AuthenticateUser == true)
            {
                Console.WriteLine("Bem-Vindo ao Sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }
    }
}
