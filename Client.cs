using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Clients
{
    public class Client
    {
        public string ClientName { get; set; }  // nome do cliente

        private double clientMoney;
        public string ClientAddress { get; set; } //endereco do cliente

        public Client(string clientName, double clientMoney, string clientAddress)
        {
            ClientName = clientName;
            ClientMoney = clientMoney;
            ClientAddress = clientAddress;
        }

        public Client()
        {

        }
        public double ClientMoney
        {
            get
            {
                return clientMoney;
            }

            set
            {
                if(value <= 0)
                {
                    return;
                }
                else
                {
                    clientMoney = value;
                }
            }
        } 



    }
}
