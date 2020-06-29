using System.Collections.Generic;
using JoesBurgerStore.Contracts;
using JoesBurgerStore.Model;
using JoesBurgerStore.Repositories;
using TestXamarinApp.Contracts;
using TestXamarinApp.Models;
using TestXamarinApp.Repositories;

namespace TestXamarinApp.Services
{
    public class BurgerDataService: IBurgerDataService
    {
        private static readonly BurgerRepository BurgerRepository = 
            new BurgerRepository();

        public List<Burger> GetAllBurgers()
        {
            return BurgerRepository.GetAllBurgers();
        }

        public List<BurgerGroup> GetGroupedBurgers()
        {
            return BurgerRepository.GetGroupedBurgers();
        }

        public List<Burger> GetBurgersForGroup(int burgerGroupId)
        {
            return BurgerRepository.GetBurgersForGroup(burgerGroupId);
        }

        public List<Burger> GetFavoriteBurgers()
        {
            return BurgerRepository.GetFavoriteBurgers();
        }

        public Burger GetBurgerById(int burgerId)
        {
            return BurgerRepository.GetBurgerById(burgerId);
        }
    }
}
