using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToShop
{
    class Item
    {
        private static int lastItemNumber = 0;

        #region Properties
        public int ItemNumber { get; private set; }

        public string ItemName { get; private set; }

        public decimal ItemPrice { get; private set; }
    }
    
        #endregion

        #region Constructor

        /*public Item(string itemName)
        {
            lastItemNumber++;
            ItemNumber = lastItemNumber;
        };*/ //How can I incorporate this to the shop?

        #endregion
}

