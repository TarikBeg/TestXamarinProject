using TestXamarinApp.Constants;
using TestXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        CalculatorPageViewModel vm = new CalculatorPageViewModel();

        public CalculatorPage()
        {
            InitializeComponent();

            this.BindingContext = vm;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            vm.NavigationService.PushAsync(PageUrls.MenuView);
        }
    }
}