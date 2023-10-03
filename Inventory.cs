using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Inventory
    {
        private Things [] _slots;

        public Inventory()
        {
            _slots = new Things [10];
        }

        public void AddItem(int index, Things things) 
        {
            _slots [index] = things;
        }

        public void ShowInventory()
        {
            int counter = 0;

            foreach (Things item in _slots)
            {
                counter++;

                if (item!=null)
                {
                    Console.WriteLine ($"Вещь: {item.Name} цвет - {item.Color} Материал - {item.Material} Вес - {item.Weight} Солт в инвенторе {counter}" );
                }   
            }
        }
    }
}
