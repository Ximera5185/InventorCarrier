using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Screwdriver:Things
    {
        private string Name { get; set; }

        public Screwdriver(string color, string material, int weight) : base(color, material, weight) 
        {
            Name = "Отвертка";
        }
    }
}
