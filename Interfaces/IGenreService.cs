using ItunesSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItunesSearcher.Interfaces
{
    public interface IGenreService
    {
        List<Genre> GetGenres();
    }
}
