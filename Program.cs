using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Game game = new Game();

            game.Run();
        } 
    }
}
