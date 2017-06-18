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
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Browse Items");
                Console.WriteLine("2. Create New Cart");
                Console.WriteLine("3. Return to Existing Cart");
                Console.WriteLine("4. Go to Checkout");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                    case "2":
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        Console.Write("Cart Name: ");
                        var cartName = Console.ReadLine();
                        Console.Write("Type of Delivery: ");
                        var deliveryTypes = Enum.GetNames(typeof(DeliveryType));
                        for (int i = 0; i < deliveryTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {deliveryTypes[i]}");
                        }
                        Console.WriteLine("Pick a Delivery Type: ");
                        var deliveryType = Convert.ToInt32(Console.ReadLine());
                        var cart = Shop.CreateCart(emailAddress, cartName, (DeliveryType)deliveryType);
                        Console.WriteLine($"CN: {cart.EmailAddress}, {cart.CartName}, {cart.DeliveryType} ");
                        break;
                    case "3":
                    case "4":
                    default:
                        break;
                }
            }

            /*var cart = new Cart("My Birthday Shopping", "test@test.com", DeliveryType.PriorityShipping);
            //Does the item class need to be nested within the class Cart? 

            Console.WriteLine($"CustomerIdNumber: {cart.CustomerIdNumber}, BalanceOwed: {cart.BalanceOwed}, EmailAddress: {cart.EmailAddress}, DeliveryType: {cart.DeliveryType} "); */
        }
    }
}
