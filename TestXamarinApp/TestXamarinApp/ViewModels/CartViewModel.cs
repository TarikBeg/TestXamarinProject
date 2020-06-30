using System.Collections.ObjectModel;
using JoesBurgerStore.Extensions;
using TestXamarinApp.Models;
using TestXamarinApp.ViewModels.Base;

namespace TestXamarinApp.ViewModels
{
    public class CartViewModel : ViewModelBase
    {
        public ObservableCollection<CartItem> CartItems{ get; set; }

        public CartViewModel()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            CartItems = CartDataService.GetCart().CartItems.ToObservableCollection();
        }
    }
}
