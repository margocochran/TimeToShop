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
    class Cart
    {
        private static int lastCustomerIdNumber = 0; 

        #region Properties
    
        public int CustomerIdNumber { get; private set; }

        public string CartName { get; set; }

        public string EmailAddress { get; set; }

        public decimal BalanceOwed { get; private set; }
        #endregion

        #region Constructor

        public Cart()
        {
            lastCustomerIdNumber ++;
            CustomerIdNumber = lastCustomerIdNumber; 
        }

        #endregion

        #region Methods
        public void AddItem(string itemName, decimal itemPrice)
        {
            BalanceOwed += itemPrice; 
        }
        public void DeleteItem(string itemName, decimal itemPrice)
        {
            BalanceOwed -= itemPrice; 
        }
        #endregion
    }
}
