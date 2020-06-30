using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestXamarinApp.Constants;
using TestXamarinApp.Contracts;
using TestXamarinApp.ViewModels;
using TestXamarinApp.Views;
using Xamarin.Forms;

namespace TestXamarinApp.Services
{
    public class NavigationService : INavigationService
    {
        private ContentPage GetPage(string pageName, object objectToPass = null)
        {
            switch (pageName)
            {
                case PageUrls.MenuView: return new MenuView();
                case PageUrls.LoginPage: return new LoginPage();
                case PageUrls.OrderBurgersView: return new OrderBurgersView(new OrderBurgersViewModel());
                //case PageUrls.ShowMapView: return new ShowMapView();
                //case PageUrls.TakePictureView: return new TakePictureView();
                case PageUrls.BurgerDetailView: return new BurgerDetailView(objectToPass);
            }
            return null;
        }
        protected Application CurrentApplication => Application.Current;

        public INavigation Navigation { get; set; }

        public IReadOnlyList<Page> ModalStack
        {
            get
            {
                return Navigation.ModalStack;
            }
        }

        public IReadOnlyList<Page> NavigationStack
        {
            get
            {
                return Navigation.NavigationStack;
            }
        }

        public void InsertPageBefore(string pageName, string beforeName)
        {
            Navigation.InsertPageBefore(GetPage(pageName), GetPage(beforeName));
        }

        public Task<Page> PopAsync()
        {
            return Navigation.PopAsync();
        }

        public Task<Page> PopAsync(bool animated)
        {
            return Navigation.PopAsync(animated);
        }

        public Task<Page> PopModalAsync()
        {
            return Navigation.PopModalAsync();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            return Navigation.PopModalAsync(animated);
        }

        public Task PopToRootAsync()
        {
            return Navigation.PopToRootAsync();
        }

        public Task PopToMainView()
        {
            return Navigation.PushAsync(new NavigationPage(new MenuView()));
        }

        public Task PopToRootAsync(bool animated)
        {
            return Navigation.PopToRootAsync(animated);
        }

        public Task PushAsync(string pageName)
        {
            var page = GetPage(pageName);

            return Navigation.PushAsync(page);
        }

        public Task PushAsync(string pageName, object objectToPass)
        {
            ContentPage page = GetPage(pageName);
            //page.ViewModel.PassedDataContext = objectToPass;
            return Navigation.PushAsync(page);
        }

        public Task PushAsync(string pageName, bool animated)
        {
            return Navigation.PushAsync(GetPage(pageName), animated);
        }

        public Task PushModalAsync(string pageName, object objectToPass)
        {
            ContentPage page = GetPage(pageName, objectToPass);
            //page.ViewModel.PassedDataContext = objectToPass;
            //Navigation = CurrentApplication.MainPage.Navigation;
            try
            {
                //await PopAsync();
                return Navigation.PushAsync(new NavigationPage(new BurgerDetailView((objectToPass))));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task PushModalAsync(string pageName, bool animated)
        {
            return Navigation.PushModalAsync(GetPage(pageName), animated);
        }

        public void RemovePage(string pageName)
        {
            Navigation.RemovePage(GetPage(pageName));
        }

        public void PushAsync(object burgerDetailView)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(string pageName)
        {
            return Navigation.PushModalAsync(GetPage(pageName));
        }
    }
}
