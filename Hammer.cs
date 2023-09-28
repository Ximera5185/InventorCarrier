using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Hammer:Things
    {
        private string Name { get; set; }

        public Hammer(string color, string material, int weight) : base(color, material, weight)
        {
            Name = "Молоток";
        }
    }
}
