using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ItunesSearcher.Models;
using ItunesSearcher.Interfaces;

namespace ItunesSearcher.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IWishService WishService { get; }

        public HomeController(ILogger<HomeController> logger, IWishService wishService)
        {
            _logger = logger;
            WishService = wishService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userId = User.GetUserId();

                WishService.GetWishesByUserId(userId);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
