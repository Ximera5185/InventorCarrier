using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Inventory
    {
        public Inventory() 
        {
            MaximumCapacity = 10;
        }
        public int MaximumCapacity { get;private set; }

        public List<Things> jackets = new List<Things>();

        public List<Things> pants = new List<Things>();

        public List<Things> hats = new List<Things>();

        public List<Things> socks = new List<Things>();

        public List<Things> shirts = new List<Things>();

        public List<Things> hammers = new List<Things>();

        public  List<Things> helmets = new List<Things>();

        public List<Things> screwdrivers = new List<Things>();   
    }
}
