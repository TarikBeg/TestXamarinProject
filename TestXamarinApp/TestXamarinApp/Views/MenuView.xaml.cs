using JoesBurgerStore.Views;
using System;
using TestXamarinApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinApp.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();

            BindingContext = new MenuViewModel();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            IsBusy = false;
            Navigation.PushModalAsync(new NavigationPage(new TestXamarinApp.Views.OrderBurgersView(new OrderBurgersViewModel())));
        }

        private void Button_OnClicked2(object sender, EventArgs e)
        {
            IsBusy = false;
            Navigation.PushModalAsync(new NavigationPage(new CartView()));
        }

        private void Button_OnClicked3(object sender, EventArgs e)
        {
            IsBusy = false;
            Navigation.PushModalAsync(new CalculatorPage());
        }
    }
}