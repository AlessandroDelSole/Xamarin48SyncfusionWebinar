using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin48Webinar.Model;

namespace Xamarin48Webinar.ViewModel
{
    public class ProductViewModel //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged([CallerMemberName]
        //        string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this,
        //        new PropertyChangedEventArgs(propertyName));
        //}

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
            set
            {
                _selectedProduct = value;
                //OnPropertyChanged();
            }
        }

        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
            Products.Add(new Product { ProductName = "Tomatoes", ProductQuantity = 100, ProductImage="tomatoes.png" });
            Products.Add(new Product { ProductName = "Potatoes", ProductQuantity = 50, ProductImage = "potatoes.png" });
            Products.Add(new Product { ProductName = "Mushrooms", ProductQuantity = 120, ProductImage = "mushrooms.png" });
            Products.Add(new Product { ProductName = "Eggplants", ProductQuantity = 80, ProductImage = "eggplants.png" });
        }
    }
}
