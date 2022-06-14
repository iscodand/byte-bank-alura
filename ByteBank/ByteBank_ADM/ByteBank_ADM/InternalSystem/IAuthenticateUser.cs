using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.InternalSystem
{
    public interface IAuthenticateUser
    {
        public bool Authenticate(string login, string password);
    }
}
