using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Helmet:Things
    {
        public Helmet(string color, string material, int weight) : base(color, material, weight)
        {
            Name = "Каска";
        }

        private string Name { get; set; }
    }
}
