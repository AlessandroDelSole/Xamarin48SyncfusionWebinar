using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin48Webinar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "Brush_Experimental", 
                                           "Shapes_Experimental",
                                           "MediaElement_Experimental", 
                                           "IndicatorView_Experimental",
                                           "Expander_Experimental"});

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
