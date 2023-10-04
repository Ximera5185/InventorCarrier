using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Player player = new Player();

            Things thing = new Things("Куртка","Синяя","Ткань",200);
            Things thing1 = new Things("Куртка", "Синяя", "Ткань", 200);

            player.AddItemToInventory(thing);
            player.AddItemToInventory(thing);

            player.ShowInventory();

            Console.ReadKey();
        }
    }
}
