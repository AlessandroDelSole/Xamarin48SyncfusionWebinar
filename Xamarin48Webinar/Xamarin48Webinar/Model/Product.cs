using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Xamarin48Webinar.Model
{
    public class Product : INotifyPropertyChanged
    {
        private string productName;
        private string productImage;
        private int productQuantity;

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
                OnPropertyChanged();
            }
        }
        public string ProductImage
        {
            get
            {
                return productImage;
            }
            set
            {
                productImage = value;
                OnPropertyChanged();
            }
        }

        public int ProductQuantity
        {
            get
            {
                return productQuantity;
            }
            set
            {
                productQuantity = value;
                OnPropertyChanged();
            }
        }

        public string QuantityIndicator
        {
            get
            {
                return $"Quantity in stock: {ProductQuantity}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]
                string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
