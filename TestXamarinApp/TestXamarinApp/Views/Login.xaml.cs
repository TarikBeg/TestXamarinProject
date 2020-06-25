
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public string Password { get; set; }
        public string UserName { get; set; }

        public Login()
        {
            InitializeComponent();
            BindingContext = this;

        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            string _userName = "TarikBeg";
            string _password = "123";

            if (_userName == UserName && _password == Password)
            {
                IsBusy = false;
                await Navigation.PushModalAsync(new NavigationPage(new CalculatorPage()));
            }
            else
            {
                await DisplayAlert("This username/password combination isn't known",
                   "Error logging you in",
                   "OK");
            }
        }
    }
}