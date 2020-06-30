using System;
using TestXamarinApp.Constants;
using TestXamarinApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinApp.Views
{
    public partial class MenuView : ContentPage
    {
        MenuViewModel vm = new MenuViewModel();
        public MenuView()
        {
            InitializeComponent();

            BindingContext = vm;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            IsBusy = false;
            vm.NavigationService.PushAsync(PageUrls.OrderBurgersView);
        }

        private void Button_OnClicked2(object sender, EventArgs e)
        {
            IsBusy = false;
            vm.NavigationService.PushAsync(PageUrls.CartView);
        }

        private void Button_OnClicked3(object sender, EventArgs e)
        {
            IsBusy = false;
            vm.NavigationService.PushModalAsync(PageUrls.CalculatorView);
        }

        void Button_Clicked4(System.Object sender, System.EventArgs e)
        {
            vm.NavigationService.PushModalAsync(PageUrls.CartView);
        }
    }
}