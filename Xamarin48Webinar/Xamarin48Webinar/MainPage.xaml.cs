using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin48Webinar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void IndiViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IndicatorViewPage());
        }

        private async void ExpanderButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpanderPage());

        }

        private async void BrushesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Brushes());

        }

        private async void ShapesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShapesPage());

        }

        private async void MediaButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MediaElementPage());

        }
    }
}
