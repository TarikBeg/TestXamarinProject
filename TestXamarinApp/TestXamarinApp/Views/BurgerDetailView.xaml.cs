using TestXamarinApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinApp.Views
{
    public partial class BurgerDetailView : ContentPage
    {
        public BurgerDetailView()
        {
            InitializeComponent();
        }

        public BurgerDetailView(object objectToPass)
        {
            InitializeComponent();
            this.BindingContext = new BurgerDetailViewModel(objectToPass);
        }
    }
}
