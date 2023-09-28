using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Shirt:Things
    {
        private string Name { get; set; }

        public Shirt(string color, string material, int weight) : base(color, material, weight)
        {
            Name = "Рубашка";
        }
    }
}
