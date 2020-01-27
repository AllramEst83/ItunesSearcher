using ItunesSearcher.Controllers;
using ItunesSearcher.Data;
using ItunesSearcher.Interfaces;
using ItunesSearcher.Models;
using ItunesSearcher.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItunesSearcher.Services
{
    public class WishService : IWishService
    {
        public List<Wish> ListOfUserWishes { get; set; } = new List<Wish>();

        public WishService(WishlistDbContext wishlistDbContext)
        {
            WishlistDbContext = wishlistDbContext;
        }

        public WishlistDbContext WishlistDbContext { get; }

        public void GetWishesByUserId(string userId)
        {
            Guid parsedUserId = Guid.Parse(userId);
            ListOfUserWishes = WishlistDbContext.Wishes.Where(x => x.UserId == parsedUserId).ToList();
        }

        public bool UserHasWishes()
        {
            return ListOfUserWishes.Count == 0 ? false : true;
        }

        public List<Wish> ReturnUserWishes()
        {
            return ListOfUserWishes;
        }

        public ResponseModel RemoveWish(int appId, string userId)
        {
            ResponseModel response;

            try
            {
                Guid parsedUserId = Guid.Parse(userId);
                bool wishExists = WishlistDbContext.Wishes.Any(x => x.AppId == appId && x.UserId == parsedUserId);
                if (wishExists)
                {
                    Wish wishToRemove = WishlistDbContext.Wishes.FirstOrDefault(x => x.AppId == appId && x.UserId == parsedUserId);
                    WishlistDbContext.Wishes.Remove(wishToRemove);

                    WishlistDbContext.SaveChanges();

                    response = new ResponseModel() { Message = "App has been successfully removed", Data = wishToRemove };

                    return response;

                }

                response = new ResponseModel() { Message = "App is already removed" };
            
            }
            catch (Exception ex)
            {
                response = new ResponseModel() { Message = $"App failed to be removed: {ex.Message}", Data = ex };
            }

            return response;
        }

        public ResponseModel AddWish(NewAppWish wishToAdd, string userId)
        {
            ResponseModel response;

            try
            {
                Guid parsedUserId = Guid.Parse(userId);
                bool idExitst = WishlistDbContext.Wishes.Any(x => x.AppId == wishToAdd.AppId);

                if (!idExitst)
                {
                    Wish newWish = new Wish()
                    {
                        AppId = wishToAdd.AppId,
                        UserId = parsedUserId,
                        TrackName = wishToAdd.TrackName,
                        Beskrivning = wishToAdd.Beskrivning,
                        AppImageUrl = wishToAdd.AppImageUrl
                    };

                    WishlistDbContext.Wishes.Add(newWish);
                    WishlistDbContext.SaveChanges();

                    response = new ResponseModel() { Message = "App has successfully been added", Data = newWish, AppAdded = true };

                    return response;
                }

                response = new ResponseModel() { Message = "App is already added", AppAdded = false };

            }
            catch (Exception ex)
            {
                response = new ResponseModel() { Message = $"App failed to be added: {ex}", Data = ex };
            }

            return response;
        }





    }

}
