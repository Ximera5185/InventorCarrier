using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Socks: Things
    {
        public Socks(string color, string material, int weight) : base(color, material, weight)
        {
            Name = "Носки";
        }

        private string Name { get; set; }
    }
}
