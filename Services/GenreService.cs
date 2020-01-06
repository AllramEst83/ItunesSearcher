using ItunesSearcher.Interfaces;
using ItunesSearcher.Models;
using ItunesSearcher.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItunesSearcher.Services
{
    public class GenreService : IGenreService
    {
        public List<Genre> GetGenres()
        {
            GenreViewModel genresViewModel = new GenreViewModel();

            return genresViewModel.Genres;
        }

    }
}
