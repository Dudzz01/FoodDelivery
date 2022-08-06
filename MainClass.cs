using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDelivery;
using FoodDelivery.Clients;
public class MainClass
{
    public static void Main(string[] args)
    {
         OrderSystemFood order1 = new OrderSystemFood(new Client(), "Eduardo Mury Assafin", "Estrada dos Menezes 400", 500, "Hamburguer","Pizza", "Refrigerante");
         Console.WriteLine("Nome: "+ order1.ClientDefault.ClientName +" /Endereco: "+ order1.ClientDefault.ClientAddress +" /Saldo após compra: "+ order1.ClientDefault.ClientMoney);
         Console.WriteLine("Comidas que foram pedidas: "+ order1.ItemsFoodSelected[0]+ " " + order1.ItemsFoodSelected[1] + " " + order1.ItemsFoodSelected[2]);
         Console.ReadLine();
    }
}
