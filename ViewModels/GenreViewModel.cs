using ItunesSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItunesSearcher.ViewModels
{
    public class GenreViewModel
    {
        public List<Genre> Genres { get; set; }

        public GenreViewModel()
        {
            Genres = new List<Genre>()
            {
                new Genre() {GenreId=  6014, GenreName = "Games"},
                new Genre() {GenreId=  0000, GenreName = "All"},
                new Genre() {GenreId=  6000, GenreName = "Business"},
                new Genre() {GenreId=  6001, GenreName = "Weather"},
                new Genre() {GenreId=  6002, GenreName = "Utilities"},
                new Genre() {GenreId=  6003, GenreName = "Travel"},
                new Genre() {GenreId=  6004, GenreName = "Sports"},
                new Genre() {GenreId=  6005, GenreName = "Social Networking"},
                new Genre() {GenreId=  6006, GenreName = "Reference"},
                new Genre() {GenreId=  6007, GenreName = "Productivity"},
                new Genre() {GenreId=  6008, GenreName = "Photo & Video"},
                new Genre() {GenreId=  6009, GenreName = "News"},
                new Genre() {GenreId=  6010, GenreName = "Navigation"},
                new Genre() {GenreId=  6011, GenreName = "Music"},
                new Genre() {GenreId=  6012, GenreName = "Lifestyle"},
                new Genre() {GenreId=  6013, GenreName = "Health & Fitness"}                
            };
        }
    }
}
