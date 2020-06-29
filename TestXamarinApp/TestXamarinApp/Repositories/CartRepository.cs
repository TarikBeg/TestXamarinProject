using System.Collections.Generic;
using JoesBurgerStore.Model;
using TestXamarinApp.Models;

namespace TestXamarinApp.Repositories
{
    public class CartRepository
    {
        static readonly Cart MainCart = new Cart() { CartItems = new List<CartItem>() };

        public void AddCartItem(Burger burger, int amount)
        {
            MainCart.CartItems.Add(new CartItem() { Burger = burger, Amount = amount });
        }

        public Cart GetCart()
        {
            return MainCart;
        }
    }
}
