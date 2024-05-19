using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class Player: INotifyPropertyChanged
    {
        private readonly string _name;
        private int _gold;
        private readonly Inventory _inventory;
        public event PropertyChangedEventHandler PropertyChanged;

        public Player(string name)
        {
            _name = name;
            _gold = 0;
            _inventory = new Inventory();
        }

        public string Name
        {
            get { return _name; }
        }

        public int Gold
        {
            get { return _gold; }
            private set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }

        public void ReceiveGold(int amount)
        {
            Gold += amount;
        }

        public void SpendGold(int amount)
        {
            Gold -= amount;
        }

        public void SellAllItemsInInventory()
        {
            ReceiveGold(_inventory.SellInventory());
        }

        private void OnPropertyChanged(string property_name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
