using System.ComponentModel;
using TestXamarinApp.Models;

namespace TestXamarinApp.Contracts.ViewModels
{
    public interface IBurgerDetailViewModel : INotifyPropertyChanged
    {
        Burger SelectedBurger { get; set; }
    }
}