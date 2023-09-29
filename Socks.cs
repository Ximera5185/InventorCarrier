using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Socks: Things
    {
        public Socks(string name, string color, string material, int weight) : base(name,color, material, weight) { }
    }
}
