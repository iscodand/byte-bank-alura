using System;

namespace ByteBankApp.Titular
{
    public class Client
    {
        public string ClientName { get; set; }
        public string ClientCPF { get; set; }
        public string ClientOccupation { get; set; }

        public Client()
        {
            TotalClient += 1;
        }
        public static int TotalClient { get; set; }
        
    }
}