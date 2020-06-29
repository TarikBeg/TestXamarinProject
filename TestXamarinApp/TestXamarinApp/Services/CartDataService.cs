using JoesBurgerStore.Model;
using TestXamarinApp.Contracts;
using TestXamarinApp.Models;
using TestXamarinApp.Repositories;

namespace TestXamarinApp.Services
{
    public class CartDataService : ICartDataService
    {
        private static readonly CartRepository CartRepository = new CartRepository();

        public void AddCartItem(Burger burger, int amount)
        {
            CartRepository.AddCartItem(burger, amount);
        }

        public Cart GetCart()
        {
            return CartRepository.GetCart();
        }
    }
}
