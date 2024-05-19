using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class InventoryItem: INotifyPropertyChanged
    {
        private readonly Item _detail;
        private int _quantity;
        public event PropertyChangedEventHandler PropertyChanged;

        public InventoryItem(Item detail, int quantity)
        {
            _detail = detail;
            _quantity = quantity;
        }

        public Item Detail
        {
            get { return _detail; }
        }

        public string ItemName
        {
            get { return _detail.Name; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set 
            { 
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public int Single
        {
            get { return _detail.Price; }
        }

        public int TotalPrice
        {
            get { return _detail.Price * _quantity; }
        }

        public void AddMoreItem(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveLessItem(int quantity)
        {
            if (Quantity > quantity)
                Quantity -= quantity;
        }

        public bool IsItem(Item item)
        {
            return (_detail == item);
        }

        private void OnPropertyChanged(string property_name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
