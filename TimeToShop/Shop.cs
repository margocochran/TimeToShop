using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToShop
{
    static class Shop
    {
        //Add properties to the shop
        private static List<Cart> carts = new List<Cart>(); 

        public static string Name { get; set; }

        public static Cart CreateCart(string emailaddress, string cartName, DeliveryType deliveryType)
        {
            var cart = new Cart
            {
                EmailAddress = emailaddress, 
                CartName = cartName, 
                DeliveryType = deliveryType
            };

            carts.Add(cart); 
            return cart; 
        }

        public static List<Cart> GetAllCarts()
        {
            return carts; 
        }
    }
}
