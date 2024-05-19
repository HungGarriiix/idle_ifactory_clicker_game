using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class RecipeItem
    {
        private readonly Item _detail;
        private readonly int _quantity;

        public RecipeItem(Item detail, int quantity)
        {
            _detail = detail;
            _quantity = quantity;
        }

        public Item Detail
        {
            get { return _detail; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public override string ToString()
        {
            return $"{_detail.Name} x {_quantity}\n";
        }
    }
}
