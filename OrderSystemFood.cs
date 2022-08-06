using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDelivery.Clients;

namespace FoodDelivery
{
    public class OrderSystemFood 
    {
        public double TotalValueFood { get; set; }  //valor total
        public Client ClientDefault { get; set; } // Cliente
        public double PriceFoods { get; set; } // preco das comidas

        private string[] itemsFoodOption = {"Hamburguer","Batata Frita", "Refrigerante", "Bolo", "Pizza", "Lasanha"};
        private string[] itemsFoodSelected = new string[3];

        public OrderSystemFood(Client client, string clientName, string clientAddress, double clientMoney, string food1, string food2, string food3)
        {
                 ClientDefault = client;
                 ClientDefault.ClientName = clientName;
                 ClientDefault.ClientAddress = clientAddress;
                 ClientDefault.ClientMoney = clientMoney;
                 SaveFoodsSelecteds(food1,food2 ,food3);
                 
        }

        public OrderSystemFood()
        {
            //Sobrecarga do metodo construtor
        }

        public string[] ItemsFoodSelected
        {
            get
            {
                return itemsFoodSelected;
            }
            set
            {
                itemsFoodSelected = value;
            }
        }

        public void SaveFoodsSelecteds(string food1, string food2, string food3)
        {
            int auxArrayFoodSelected = 0; // contador do index do array  itemsFoodSelected

            for (int i = 0; i < itemsFoodOption.Length-1; i++)
            {
                if (itemsFoodOption[i] == food1 || itemsFoodOption[i] == food2 || itemsFoodOption[i] == food3)
                {
                    itemsFoodSelected[auxArrayFoodSelected] = itemsFoodOption[i]; // Seleciono esse item
                    SetPriceFoodsSelected(itemsFoodSelected[auxArrayFoodSelected]);     // Selecionando o preco da comida escolhida 
                    auxArrayFoodSelected++;
                    if (auxArrayFoodSelected >2)
                    {
                        break;
                    }
                }
            }
            ClientPayFood();
        }

        public void SetPriceFoodsSelected(string food)
        {
           
                


                    switch (food)
                    {
                            case "Hamburguer":
                            
                                PriceFoods = 20;
                                TotalValueFood += PriceFoods;
                            break;


                            case "Lasanha":

                                PriceFoods = 28;
                                TotalValueFood += PriceFoods;
                            break;

                            case "Pizza":

                                PriceFoods = 40;
                                TotalValueFood += PriceFoods;
                            break;

                            case "Refrigerante":

                                PriceFoods = 6;
                                TotalValueFood += PriceFoods;
                            break;

                            case "Bolo":

                                PriceFoods = 30;
                                TotalValueFood += PriceFoods;
                            break;

                            case "Batata Frita":

                                PriceFoods = 14;
                                TotalValueFood += PriceFoods;
                            break;
            }
                
                
            
        }

        public void ClientPayFood()
        {
            if(ClientDefault.ClientMoney >= TotalValueFood)
            {
                ClientDefault.ClientMoney -= TotalValueFood;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para comprar os itens, carrinho sendo limpado automaticamente");
                for (int i = 0; i < itemsFoodSelected.Length - 1; i++)
                {
                    itemsFoodSelected[i] = "";

                }
            }
        }

       





    }
}
