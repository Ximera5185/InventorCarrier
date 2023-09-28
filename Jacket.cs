using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Jacket : Things
    {
        private int size { get; set; }
        public Jacket(string name, string color, string material, int weight, int size) : base(name, color, material, weight)
        {
            this.size = jacketSize;
        }
    }
}
