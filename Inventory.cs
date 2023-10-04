using System;

namespace InventorCarrier
{
    internal class Inventory
    {
        private Things [] _slots;

        public Inventory()
        {
            _slots = new Things [10];
        }

        public void AddItem( Things things) 
        {

            if (SearchIndex(out int index) == true)
            {
                 _slots [index] = things;
            }
            else
            {
                Console.WriteLine("Все ячейки заполнены");
            }
        }

        private bool SearchIndex(out int index) 
        {
            for (int i = 0; i < _slots.Length; i++)
            {
                if (_slots [i] == null)
                {
                    index = i;
                    
                    return true;
                    
                }
            }

            index = 0;

            return  false;
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
