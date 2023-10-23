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

        public void AddItem(Things things)
        {
            if (things != null)
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
            else
            {
                Console.Clear();
                Console.WriteLine("Создайте вещь для добовления в инвентарь");
                Console.ReadKey();
            }
        }

        public void RemoveItem(int index)
        {
            for (int i = 0; i < _slots.Length; i++)
            {
                if (i == index)
                {
                    if (_slots[i]!=null)
                    {
                        _slots [i] = null;
                    }
                    
                }
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

            return false;
        }

        public void ShowInventory()
        {
             int counter = 0;

            int occupiedSlotsNumber = CountNumberOfBusySlots();

            Console.WriteLine($"Инвентарь игрока: {occupiedSlotsNumber}/{_slots.Length}");

            foreach (Things item in _slots)
            {
              counter++;

                if (item != null)
                {
                    Console.WriteLine($"Слот {counter}: {item.Name} цвет - {item.Color} Материал - {item.Material} Вес - {item.Weight}");
                }
                else
                {
                    Console.WriteLine($"Слот {counter} пуст");
                }
            }

            Console.WriteLine();
        }

        private int CountNumberOfBusySlots() 
        {
            int minValue = 0;

            int occupiedSlotsNumber = minValue;

            for (int i = 0; i < _slots.Length; i++)
            {
                if (_slots[i]!=null)
                {
                    occupiedSlotsNumber++;
                } 
            }

            return occupiedSlotsNumber;
        }
    }
}
