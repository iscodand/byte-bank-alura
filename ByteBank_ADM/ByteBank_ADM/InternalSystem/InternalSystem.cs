using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.InternalSystem
{
    public class InternalSystem
    {
        public bool Login(IAuthenticateUser user, string login, string password)
        {

            bool AuthenticateUser = user.Authenticate(login, password);

            if (AuthenticateUser == true)
            {
                Console.WriteLine("Bem-Vindo ao Sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha e/ou Usuário Incorretos!");
                return false;
            }
        }
    }
}
