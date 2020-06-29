using System.Windows.Input;
using TestXamarinApp.Constants;
using TestXamarinApp.ViewModels.Base;
using Xamarin.Forms;

namespace TestXamarinApp.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public ICommand OrderBurgerCommand => new Command(OnOrderBurger);

        private async void OnOrderBurger(object obj)
        {
            await NavigationService.PushAsync(PageUrls.OrderBurgersView);
        }
    }
}