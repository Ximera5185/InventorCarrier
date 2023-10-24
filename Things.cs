using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Things
    {
        public Things(string name, string color, string material, int weight)
        {
            Name = name;

            Color = color;

            Material = material;

            Weight = weight;
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public string Material { get; set; }

        public int Weight { get; set; }
    }
}
