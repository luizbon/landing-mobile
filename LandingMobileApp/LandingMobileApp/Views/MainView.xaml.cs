using Xamarin.Forms;

namespace LandingMobileApp.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = App.Locator.Main;
        }
    }
}