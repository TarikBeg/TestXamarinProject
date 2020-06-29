using JoesBurgerStore.Extensions;
using JoesBurgerStore.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TestXamarinApp.Constants;
using TestXamarinApp.Contracts.ViewModels;
using TestXamarinApp.Models;
using TestXamarinApp.ViewModels.Base;
using Xamarin.Forms;

namespace TestXamarinApp.ViewModels
{
    public class OrderBurgersViewModel : ViewModelBase, IOrderBurgersViewModel
    {
        public ObservableCollection<Burger> Burgers { get; set; }
        public ObservableCollection<BurgerGroup> BurgerGroups { get; set; }

        public ICommand LoadCommand { get; set; }
        public Command BurgerSelectedCommand { get; set; }

        public OrderBurgersViewModel()
        {

            //Burgers = burgerDataService.GetAllBurgers().ToObservableCollection();
            InitializeCommands();
            //Burgers = burgerDataService.GetAllBurgers().ToObservableCollection();
            BurgerGroups = BurgerDataService.GetGroupedBurgers().ToObservableCollection();
        }

        private void InitializeCommands()
        {
            BurgerSelectedCommand = new Command(async (burger) =>
            {
                await NavigationService.PushModalAsync(PageUrls.BurgerDetailView, burger);
            });

            LoadCommand = new Command(() =>
            {

            });
        }

    }
}