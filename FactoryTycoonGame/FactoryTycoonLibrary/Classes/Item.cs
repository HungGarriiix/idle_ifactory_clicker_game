using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class Item: ObtainableObject
    {
        private readonly int _price;

        public Item(int id, string name, int price, string description): base(id, name, description)
        {
            _price = price;
        }

        public int Price
        {
            get { return _price; }
        }
    }
}
