using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItunesSearcher.Interfaces;
using ItunesSearcher.Models;
using ItunesSearcher.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItunesSearcher.Controllers
{

    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        private ILogger<GenreController> _logger;

        public IGenreService GenreService { get; }

        public GenreController(IGenreService genreService, ILogger<GenreController> logger)
        {
            _logger = logger;
            GenreService = genreService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Genre> Get()
        {
            _logger.LogInformation("Éntered genre controller");

            List<Genre> genresViewModel = GenreService.GetGenres();

            _logger.LogInformation("Genres collected.", genresViewModel);

            return genresViewModel;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
