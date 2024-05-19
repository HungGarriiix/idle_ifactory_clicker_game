using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class Recipe: ObtainableObject
    {
        private readonly List<RecipeItem> _required;
        private readonly RecipeItem _product;

        public Recipe(int id, string name, List<RecipeItem> required, RecipeItem product, string description): base(id, name, description)
        {
            _required = required;
            _product = product;
        }

        public List<RecipeItem> Required
        { 
            get { return _required; } 
        }

        public RecipeItem Product
        {
            get { return _product; }
        }

        public string Details
        {
            get 
            {
                return GetRequiredDetail() +
                       GetProductDetail();
            }
        }

        private string GetRequiredDetail()
        {
            string s = "Required:\n\n";
            foreach(RecipeItem item in _required)
            {
                s += "  " + item.ToString() + "\n";
            }
            return s;
        }

        private string GetProductDetail()
        {
            return $"Product:\n\n" +
                   $"   {_product.ToString()}\n";
        }
    }
}
