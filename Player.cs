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
        private Inventory inventory = new Inventory();

        public void AddItemToInventory(Things thing)
        {
            if (thing.Name == "Отвертка")
            {
                inventory.screwdrivers.Add(thing);
            }
            if (thing.Name == "Каска")
            {
                inventory.helmets.Add(thing);
            }
            if (thing.Name == "Молоток")
            {
                inventory.hammers.Add(thing);
            }
            if (thing.Name == "Рубашка")
            {
                inventory.shirts.Add(thing);
            }
            if (thing.Name == "Носки")
            {
                inventory.socks.Add(thing);
            }
            if (thing.Name == "Шапка")
            {
                inventory.hats.Add(thing);
            }
            if (thing.Name == "Брюки")
            {
                inventory.pants.Add(thing);
            }
            if (thing.Name == "Куртка")
            {
                inventory.jackets.Add(thing);
            }
        }

        public Things FindAnItem()
        {
            Things thing = null;

            int minValue = 1;
            int maxValue = 10;

            Random random = new Random();

            switch (random.Next(minValue, maxValue))
            {
                case 1:
                    thing = new Screwdriver("Отвертка", "Синий", "Метал", 200);
                    break;
                case 2:
                    thing = new Helmet("Каска", "Зеленый", "Метал", 200);
                    break;
                case 3:
                    thing = new Hammer("Молоток", "Черный", "Метал", 200);
                    break;
                case 4:
                    thing = new Shirt("Рубашка", "Белая", "Ткань", 200);
                    break;
                case 5:
                    thing = new Socks("Носки", "Черный", "Ткань", 200);
                    break;
                case 6:
                    thing = new Hat("Шапка", "Жолтый", "Ткань", 200);
                    break;
                case 7:
                    thing = new Pant("Брюки", "Синий", "Ткань", 200);
                    break;
                case 9:
                    thing = new Jacket("Куртка", "Черный", "Ткань", 200);
                    break;
            }

            return thing;
        }

        public void ShowBackpack()
        {
            Console.WriteLine(
            $"Отвертки {inventory.screwdrivers.Count} / {inventory.MaximumCapacity}\n" +
            $"Каски  {inventory.helmets.Count} / {inventory.MaximumCapacity}\n" +
            $"Молотки {inventory.hammers.Count} / {inventory.MaximumCapacity}\n" +
            $"Рубашки {inventory.shirts.Count} / {inventory.MaximumCapacity}\n" +
            $"Носки {inventory.socks.Count} /  {inventory.MaximumCapacity} \n" +
            $"Шапки {inventory.hats.Count} /  {inventory.MaximumCapacity} \n" +
            $"Брюки {inventory.pants.Count} /  {inventory.MaximumCapacity} \n" +
            $"Куртки {inventory.jackets.Count} / {inventory.MaximumCapacity}");
        }
    }
}
