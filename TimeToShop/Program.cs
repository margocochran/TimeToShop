using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to My Shop!*****");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Shop for Items");
            Console.WriteLine("2. Go to My Cart");
            Console.WriteLine("3. Go to Checkout");

            var choice = Console.ReadLine(); 
            switch (choice)
            {
                case "0":
                    return; 
                case "1":
                case "2":
                case "3":
                default:
                    break;
            }


            /*var cart = new Cart("My Birthday Shopping", "test@test.com", DeliveryType.PriorityShipping);
            //Does the item class need to be nested within the class Cart? 

            Console.WriteLine($"CustomerIdNumber: {cart.CustomerIdNumber}, BalanceOwed: {cart.BalanceOwed}, EmailAddress: {cart.EmailAddress}, DeliveryType: {cart.DeliveryType} "); */
        }
    }
}
