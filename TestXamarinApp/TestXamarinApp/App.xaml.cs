using TestXamarinApp.Constants;
using TestXamarinApp.Contracts;
using TestXamarinApp.Services;
using TestXamarinApp.Views;
using Xamarin.Forms;

namespace TestXamarinApp
{
    public partial class App : Application
    {
        INavigationService NavigationService => DependencyService.Get<INavigationService>();

        public App()
        {
            InitializeComponent();
            var menuView = new MenuView();
            DependencyService.Register<NavigationService>();

            NavigationService.Navigation = menuView.Navigation;

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<BurgerDataService>();
            DependencyService.Register<CartDataService>();


            MainPage = new NavigationPage(menuView);
            //MainPage = new MainPage();
            NavigationService.PushAsync(PageUrls.LoginPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
