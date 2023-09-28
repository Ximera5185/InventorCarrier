using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Hat : Things
    {
        public Hat(string color, string material, int weight) : base(color, material, weight)  
        {
            Name = "Шапка";
        }

        private string Name { get; set; }
    }
}
