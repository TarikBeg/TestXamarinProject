using TestXamarinApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinApp.Views
{
    public partial class CartView : ContentPage
    {
        public CartView()
        {
            InitializeComponent();
            var viewModel = new CartViewModel();

            this.BindingContext = viewModel;
        }
    }
}
