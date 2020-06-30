using System.Windows.Input;
using TestXamarinApp.Constants;
using TestXamarinApp.Contracts.ViewModels;
using TestXamarinApp.Models;
using TestXamarinApp.ViewModels.Base;
using Xamarin.Forms;

namespace TestXamarinApp.ViewModels
{
    public class BurgerDetailViewModel : ViewModelBase, IBurgerDetailViewModel
    {
        private Burger _selectedBurger;
        private int _amount;
        public ICommand AddToCartCommand { get; set; }
        public ICommand ReadDescriptionCommand { get; set; }


        public int Amount
        {
            get { return _amount; }
            set { _amount = value; OnPropertyChanged("Amount"); }
        }

        public Burger SelectedBurger
        {
            get
            {
                return _selectedBurger;
            }
            set
            {
                _selectedBurger = value;
                OnPropertyChanged("SelectedBurger");
            }
        }

        public BurgerDetailViewModel(object objectToPass)
        {
            SelectedBurger = objectToPass as Burger;

            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddToCartCommand = new Command(() =>
            {
                CartDataService.AddCartItem(SelectedBurger, Amount);
                NavigationService.PopToMainView();
            });

            //ReadDescriptionCommand = new Command(() =>
            //{
            //    DependencyService.Get<ITextToSpeech>().Read(SelectedBurger.ShortDescription);
            //});
        }
    }
}
