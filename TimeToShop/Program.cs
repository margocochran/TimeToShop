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
            var cart = new Cart("My Birthday Shopping", "test@test.com");
            //Does the item class need to be nested within the class Cart? 
          

            var cart2 = new Cart
            {
                EmailAddress = "test@test.com",

            };

            Console.WriteLine($"CustomerIdNumber: {cart2.CustomerIdNumber}, BalanceOwed: {cart2.BalanceOwed}, EmailAddress: {cart2.EmailAddress} ");
        }
    }
}
