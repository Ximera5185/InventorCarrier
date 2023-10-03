using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Player
    {
        public Inventory _inventory = new Inventory();
        
        public Things AddItemToInventory(Things thing)
        {
            return thing;
        }
    }
}
