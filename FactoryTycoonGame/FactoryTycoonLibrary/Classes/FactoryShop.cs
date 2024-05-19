using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class FactoryShop
    {
        private readonly List<AssignedFactory> _factories;
        public delegate void AssignFactoryEventHandler(object sender, int location_index);
        public event AssignFactoryEventHandler AssignedFactory;

        public FactoryShop()
        {
            _factories = new List<AssignedFactory>();
            AddSample();
        }

        public void AddSample()
        {
            _factories.Add(new AssignedFactory(1, AssetsBank.FindFactoryByID((int)FACTORY_ID.MINER)));
            _factories.Add(new AssignedFactory(2, AssetsBank.FindFactoryByID((int)FACTORY_ID.MINER)));
            _factories.Add(new AssignedFactory(3, AssetsBank.FindFactoryByID((int)FACTORY_ID.MINER)));
            _factories.Add(new AssignedFactory(4, AssetsBank.FindFactoryByID((int)FACTORY_ID.SMELTER)));
            _factories.Add(new AssignedFactory(5, AssetsBank.FindFactoryByID((int)FACTORY_ID.SMELTER)));
            _factories.Add(new AssignedFactory(6, AssetsBank.FindFactoryByID((int)FACTORY_ID.SMELTER)));
            _factories.Add(new AssignedFactory(7, AssetsBank.FindFactoryByID((int)FACTORY_ID.CONSTRUCTOR)));
            _factories.Add(new AssignedFactory(8, AssetsBank.FindFactoryByID((int)FACTORY_ID.CONSTRUCTOR)));
            _factories.Add(new AssignedFactory(9, AssetsBank.FindFactoryByID((int)FACTORY_ID.CONSTRUCTOR)));
            _factories.Add(new AssignedFactory(10, AssetsBank.FindFactoryByID((int)FACTORY_ID.ASSEMBLER)));
            _factories.Add(new AssignedFactory(11, AssetsBank.FindFactoryByID((int)FACTORY_ID.ASSEMBLER)));
            _factories.Add(new AssignedFactory(12, AssetsBank.FindFactoryByID((int)FACTORY_ID.ASSEMBLER)));
            _factories.Add(new AssignedFactory(13, AssetsBank.FindFactoryByID((int)FACTORY_ID.MANUFACTURER)));
            _factories.Add(new AssignedFactory(14, AssetsBank.FindFactoryByID((int)FACTORY_ID.MANUFACTURER)));
            _factories.Add(new AssignedFactory(15, AssetsBank.FindFactoryByID((int)FACTORY_ID.MANUFACTURER)));
        }

        public void BuyFactory(Player p, int location_index)
        {
            AssignedFactory af = GetFactoryByLocationIndex(location_index);
            if (HasEnoughGold(p, af) && !af.Owned)
            {
                af.GetOwned();
                p.SpendGold(af.FactoryType.Price);
                OnAssignedFactory(af.LocationIndex);
            }
            else
            {
                // Print message
            }
        }

        private bool HasEnoughGold(Player p, AssignedFactory af)
        {
            return (p.Gold >= af.FactoryType.Price);
        }

        public void ProduceProduct(Player p, int location_index)
        {
            AssignedFactory af = GetFactoryByLocationIndex(location_index);
            if (af.HasRequirement(p))
            {
                AddProductsToPlayer(p, af);
                RemoveRequirements(p, af);
            }
        }

        private void AddProductsToPlayer(Player p, AssignedFactory factory)
        {
            RecipeItem ri = factory.ProduceProduct();

            p.Inventory.AddItem(ri.Detail, ri.Quantity);
        }

        private void RemoveRequirements(Player p, AssignedFactory factory)
        {
            foreach (RecipeItem ri in factory.SelectedRecipe.Required)
            {
                p.Inventory.RemoveItem(ri.Detail, ri.Quantity);
            }
        }

        public AssignedFactory GetFactoryByLocationIndex(int location_index)
        {
            return _factories.SingleOrDefault(x => x.LocationIndex == location_index);
        }

        private void OnAssignedFactory(int location_index)
        {
            AssignedFactory?.Invoke(this, location_index);
        }
    }
}
