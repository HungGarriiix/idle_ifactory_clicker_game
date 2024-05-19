using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class Factory : ObtainableObject
    {
        private readonly int _price;
        private readonly List<Recipe> _availableRecipe;

        public Factory(int id, string name, int price, List<Recipe> recipes, string description) : base(id, name, description)
        {
            _price = price;
            _availableRecipe = recipes;
        }

        public int Price
        {
            get { return _price; }
        }

        public Recipe[] AvailableRecipe
        {
            get { return _availableRecipe.ToArray(); }
        }

        public void AddNewRecipe(Recipe recipe)
        {
            _availableRecipe.Add(recipe);
        }
    }
}
