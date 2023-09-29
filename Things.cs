using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Things
    {
        protected Things(string name, string color, string material, int weight)
        {
            Name = name;

            Color = color;

            Material = material;

            Weight = weight;
        }

        public string Name { get; protected set; }

        public string Color { get; protected set; }

        public string Material { get; protected set; }

        public int Weight { get; protected set; }
    }
}
