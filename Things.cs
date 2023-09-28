using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Things
    {
        private string Name { get; set; }

        private string Color { get; set; }

        private string Material { get; set; }

        private int Weight { get; set; }

        protected Things(string name, string color, string material, int weight)
        {
            Name = name;

            Color = color;

            Material = material;

            Weight = weight;
        }
    }
}
