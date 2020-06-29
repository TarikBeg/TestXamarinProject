using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;

using TestXamarinApp.Models;
using TestXamarinApp.ViewModels.Base;
using TestXamarinApp.Views;

namespace TestXamarinApp.ViewModels
{
    public class ItemsViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {

            try
            {
                Items.Clear();
                var items = Enumerable.Empty<Item>();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}