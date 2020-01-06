using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItunesSearcher.Interfaces;
using ItunesSearcher.Models;
using ItunesSearcher.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace ItunesSearcher.Controllers
{
    [Route("api/[controller]")]
    public class WishListController : Controller
    {
        public IWishService WishService { get; }

        public WishListController(IWishService wishService)
        {
            WishService = wishService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public JsonResult Post([FromBody]NewAppWish model)
        {
            ResponseModel response;

            if (User.Identity.IsAuthenticated)
            {
                string userId = User.GetUserId();
                response = WishService.AddWish(model, userId);

                return new JsonResult(response);
            }

            response = new ResponseModel { Message = "You are not Authenticated", Data = new { } };

            return new JsonResult(response);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }


        [HttpDelete]
        public JsonResult Delete(int id)
        {
            ResponseModel response;

            if (User.Identity.IsAuthenticated)
            {
                string userId = User.GetUserId();

                response = WishService.RemoveWish(id, userId);

                return new JsonResult(response);
            }

            response = new ResponseModel { Message = "You are not Authenticated", Data = new { } };

            return new JsonResult(response);

        }
    }


}
