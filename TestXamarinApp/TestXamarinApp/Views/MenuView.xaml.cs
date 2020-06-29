using System;
using System.Threading.Tasks;
using TestXamarinApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinApp.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();

            BindingContext=new MenuViewModel();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            IsBusy = false;
            Navigation.PushModalAsync(new NavigationPage(new TestXamarinApp.Views.OrderBurgersView(new OrderBurgersViewModel())));
        }
    }
}