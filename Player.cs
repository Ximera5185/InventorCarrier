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
        private Inventory _inventory = new Inventory();
        
        public void AddItemToInventory(Things thing)
        {
            _inventory.AddItem(thing);
        }

        public void RemoveItemFromInventory() 
        {
            
            Console.WriteLine("Введите номер слота для удаления вещи ");

            int index = Convert.ToInt32(Console.ReadLine());

            index--;

            _inventory.RemoveItem(index);
        }

        public void ShowInventory() 
        {
            _inventory.ShowInventory();
        }
    }
}
