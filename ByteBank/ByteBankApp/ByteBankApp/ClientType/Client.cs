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
        public string ClientCPF { get; private set; }
        public string ClientOccupation { get; set; }

        public Client(string clientCPF)
        {
            this.ClientCPF = clientCPF;
            TotalClients += 1;
        }
        public int TotalClients { get; set; }

        public void RegisterClient(Client client)
        {
            TotalClients++;
        }

        public int GetTotalClients()
        {
            return this.TotalClients;
        } 
    }
}