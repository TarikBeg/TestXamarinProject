using System.Threading.Tasks;
using System.Windows.Input;
using TestXamarinApp.Constants;
using TestXamarinApp.ViewModels.Base;
using TestXamarinApp.Views;
using Xamarin.Forms;

namespace TestXamarinApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _password1 = "";
        private string _userName2 = "";

        //public ICommand LoginCommand => new Command(OnLogin);

        //private async void OnLogin(object obj)
        //{
        //    string _userName = "TarikBeg";
        //    string _password = "123";

        //    if (_userName == UserName && _password == Password)
        //    {
        //        IsBusy = false;
        //        await NavigationService.PushModalAsync(PageUrls.MenuView);
        //    }
        //}

        public string Password
        {
            get { return _password1; }
            set
            {
                _password1 = value;
                OnPropertyChanged("Password");

            }
        }
        public string UserName
        {
            get { return _userName2; }
            set
            {
                _userName2 = value;
                OnPropertyChanged("UserName");

            }
        }


    }
}
