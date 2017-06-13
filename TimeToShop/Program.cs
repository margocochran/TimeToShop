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
            var cart = new Cart();
            cart.CartName = "My Birthday Shopping";
            cart.EmailAddress = "test@test.com";
            cart.AddItem("bat", 24);
            Console.WriteLine($"CustomerIdNumber: {cart.CustomerIdNumber}, BalanceOwed: {cart.BalanceOwed}, EmailAddress: {cart.EmailAddress} ");
        }
    }
}
