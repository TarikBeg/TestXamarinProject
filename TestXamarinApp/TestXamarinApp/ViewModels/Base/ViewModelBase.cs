using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JoesBurgerStore.Contracts;
using TestXamarinApp.Contracts;
using TestXamarinApp.Models;
using TestXamarinApp.Services;
using Xamarin.Forms;

namespace TestXamarinApp.ViewModels.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        private bool _isBusy;
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public IBurgerDataService BurgerDataService => DependencyService.Get<IBurgerDataService>();
        public INavigationService NavigationService => DependencyService.Get<INavigationService>();
        public ICartDataService CartDataService => DependencyService.Get<ICartDataService>();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        [Anntotations.NotifyPropertyChangedInvocatorAttribute]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual Task InitializeAsync(object data)
        {
            return Task.FromResult(false);
        }
    }
}