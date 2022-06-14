using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.InternalSystem;

namespace ByteBank_ADM.BusinessPartners
{
    public class BusinessPartners : IAuthenticateUser
    {
        public string InternalSystemLogin { get; set; }
        public string InternalSystemPassword { get; set; }

        public bool Authenticate(string login, string password)
        {
            return InternalSystemLogin == login && InternalSystemPassword == password;
        }
    }
}
