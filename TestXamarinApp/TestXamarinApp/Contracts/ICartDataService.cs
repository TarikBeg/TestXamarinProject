using JoesBurgerStore.Model;
using TestXamarinApp.Models;

namespace TestXamarinApp.Contracts
{
    public interface ICartDataService
    {
        void AddCartItem(Burger burger, int amount);
        Cart GetCart();
    }
}