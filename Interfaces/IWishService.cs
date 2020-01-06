using ItunesSearcher.Controllers;
using ItunesSearcher.Models;
using ItunesSearcher.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItunesSearcher.Interfaces
{
    public interface IWishService
    {
        void GetWishesByUserId(string userId);
        List<Wish> ReturnUserWishes();
        bool UserHasWishes();
        ResponseModel RemoveWish(int appId, string userId);
        ResponseModel AddWish(NewAppWish wishToAdd, string userId);

    }
}
