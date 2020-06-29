using System.Windows.Input;
using TestXamarinApp.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestXamarinApp.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        public AboutViewModel()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}