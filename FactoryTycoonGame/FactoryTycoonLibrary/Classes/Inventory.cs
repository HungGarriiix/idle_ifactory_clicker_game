using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class Inventory: INotifyPropertyChanged
    {
        private readonly BindingList<InventoryItem> _storage;
        public event PropertyChangedEventHandler PropertyChanged;

        public Inventory()
        {
            _storage = new BindingList<InventoryItem>(); 
        }

        public BindingList<InventoryItem> Storage
        {
            get { return _storage; }
        }

        public int TotalValue
        {
            get
            {
                int total = 0;
                foreach (InventoryItem i in _storage)
                {
                    total += i.TotalPrice;
                }
                return total;
            }
        }

        public void AddItem(Item item, int quantity)
        {
            if(HasItem(item))
            {
                GetItem(item).AddMoreItem(quantity);
            }
            else
            {
                InventoryItem i = new InventoryItem(item, quantity);
                _storage.Add(i);
            }
            OnPropertyChanged("TotalValue");
        }

        public bool HasItem(Item item)
        {
            return (GetItem(item) != null);
        }

        public InventoryItem GetItem(Item item)
        {
            foreach(InventoryItem i in _storage)
            {
                if(i.IsItem(item))
                {
                    return i;
                }
            }
            return null;
        }

        public void RemoveItem(Item item, int quantity)
        {
            if(HasItem(item))
            {
                InventoryItem i = GetItem(item);
                if (i.Quantity > quantity)
                    i.RemoveLessItem(quantity);
                else if (i.Quantity == quantity)
                    _storage.Remove(i);
                else
                {
                    //Add notification of too much item to delete
                }
                OnPropertyChanged("TotalValue");
            }    
        }

        public int SellInventory()
        {
            int money = TotalValue;
            _storage.Clear();
            OnPropertyChanged("TotalValue");
            return money;
        }

        private void OnPropertyChanged(string property_name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
