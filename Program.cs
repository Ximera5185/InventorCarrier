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

            Things thing;

            thing = player.FindAnItem();

            player.AddItemToInventory(thing);

            player.ShowBackpack();

            Console.ReadKey();
        }
    }
}
