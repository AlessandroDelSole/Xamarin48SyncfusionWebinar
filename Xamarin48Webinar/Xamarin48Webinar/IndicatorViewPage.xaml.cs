using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin48Webinar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndicatorViewPage : ContentPage
    {
        public IndicatorViewPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.ProductViewModel();
        }

        private void ProductList_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {

        }

        private void ProductList_PositionChanged(object sender, PositionChangedEventArgs e)
        {

        }
    }
}