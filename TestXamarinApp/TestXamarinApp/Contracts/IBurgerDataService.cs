using System.Collections.Generic;
using JoesBurgerStore.Model;
using TestXamarinApp.Models;

namespace TestXamarinApp.Contracts
{
    public interface IBurgerDataService
    {
        List<Burger> GetAllBurgers();

        List<BurgerGroup> GetGroupedBurgers();

        List<Burger> GetBurgersForGroup(int burgerGroupId);

        List<Burger> GetFavoriteBurgers();

        Burger GetBurgerById(int burgerId);
    }
}
