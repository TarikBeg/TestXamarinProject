
using TestXamarinApp.Models;
using TestXamarinApp.ViewModels.Base;

namespace TestXamarinApp.ViewModels
{
    public class ItemDetailViewModel : ViewModelBase
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}