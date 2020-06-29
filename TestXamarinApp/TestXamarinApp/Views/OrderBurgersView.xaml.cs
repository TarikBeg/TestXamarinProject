using TestXamarinApp.Models;
using TestXamarinApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinApp.Views
{
    public partial class OrderBurgersView : ContentPage
    {
        public OrderBurgersView(OrderBurgersViewModel viewModel)
        {
            InitializeComponent();


            this.BindingContext = viewModel;
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBurger = e.SelectedItem as Burger;
        }
    }
}
