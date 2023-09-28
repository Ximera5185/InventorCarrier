using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Things
    {
        private string Color { get; set; }

        private string Material { get; set; }

        private int Weight { get; set; }

        protected Things( string color, string material, int weight)
        {
            Color = color;

            Material = material;

            Weight = weight;
        }
    }
}
