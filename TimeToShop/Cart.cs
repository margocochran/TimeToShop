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
        #region Properties
    
        public int CustomerIdNumber { get; private set; }

        public int EmailAddress { get; set; }

        public decimal BalanceOwed { get; private set; }
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
        public void CheckOut(string itemName, decimal balanceOwed); //is this the correct place for this? Or should it be another class?
        #endregion
    }
}
