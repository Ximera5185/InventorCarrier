using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Hammer:Things
    {
        public Hammer(string color, string material, int weight) : base(color, material, weight)
        {
            Name = "Молоток";
        }

        private string Name { get; set; }
    }
}
