using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class AssignedFactory
    {
        private readonly int _location_index;
        private readonly Factory _factoryType;
        private Recipe _selected_recipe;
        private bool _owned;

        public AssignedFactory(int location_index, Factory type)
        {
            _location_index = location_index;
            _factoryType = type;
            _owned = false;
        }

        public int LocationIndex
        {
            get { return _location_index; }
        }

        public Factory FactoryType
        {
            get { return _factoryType; }
        }

        public Recipe SelectedRecipe
        {
            get { return _selected_recipe; }
            set { _selected_recipe = value; }
        }

        public bool Owned
        {
            get { return _owned; }
        }

        public RecipeItem ProduceProduct()
        {
            return _selected_recipe.Product;
        }

        public void GetOwned()
        {
            _owned = true;
        }

        public bool HasRequirement(Player p)
        {
            if (_selected_recipe == null)
                return false;

            foreach(RecipeItem ri in _selected_recipe.Required)
            {
                if (!p.Inventory.HasItem(ri.Detail))
                {
                    return false;
                }
                else
                {
                    if (p.Inventory.GetItem(ri.Detail).Quantity < ri.Quantity)
                        return false;
                }
            }
            return true;
        }
    }
}
