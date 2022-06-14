using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankApp.Titular
{
    public class Client
    {
        public string ClientName { get; set; }
        public string ClientCPF { get; set; }
        public string ClientOccupation { get; set; }

        public Client(string clientCPF)
        {
            this.ClientCPF = clientCPF;
            TotalClient += 1;
        }
        public static int TotalClient { get; set; }
        
    }
}