using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToShop
{
    /// <summary>
    /// This is a shopping cart that stores the customer's goods for purchase.
    /// </summary>
    public enum DeliveryType
    {
        RegularShipping,
        PriorityShipping,
        PickUp
    }

    class Cart
    {
        private static int lastCustomerIdNumber = 0; 

        #region Properties
    
        public int CustomerIdNumber { get; private set; }

        public string CartName { get; set; }

        public string EmailAddress { get; set; }

        public decimal BalanceOwed { get; private set; }

        public DeliveryType DeliveryType { get; set; }
        
        #endregion

        #region Constructor

        public Cart()
        {
            lastCustomerIdNumber ++;
            CustomerIdNumber = lastCustomerIdNumber; 
        }

        public Cart(string cartName) : this()
        {
            CartName = cartName;
        }

        public Cart(string cartName, string emailAddress) : this(cartName)
        {
            EmailAddress = emailAddress;
        }

        public Cart(string cartName, string emailAddress, DeliveryType deliveryType) : this(cartName, emailAddress)
        {
            DeliveryType = deliveryType; 
        }
        #endregion

        #region Methods
        /*public void AddItem(string itemName, decimal itemPrice)
        {
            BalanceOwed += itemPrice; 
        }
        public void DeleteItem(string itemName, decimal itemPrice)
        {
            BalanceOwed -= itemPrice; 
        }*/
        //Is this section needed? I keep getting errors and must be entering the wrong components of a method.
        #endregion
    }
}
