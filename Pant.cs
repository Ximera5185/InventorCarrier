using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Pant : Things
    {
        public Pant(string name, string color, string material, int weight) : base(name, color, material,  weight)  {  }
    }
}
