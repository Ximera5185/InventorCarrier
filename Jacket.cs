using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Jacket : Things
    {
        public Jacket( string color, string material, int weight) : base(color, material, weight)
        {
            Name = "Куртка";
        }

        private string Name { get;  set;}
    }
}
