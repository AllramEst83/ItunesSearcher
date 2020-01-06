using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItunesSearcher.Models
{
    public class Wish
    {
        public int Id { get; set; }
        public int AppId { get; set; }
        public string TrackName { get; set; }
        public string Beskrivning { get; set; }
        public Guid? UserId { get; set; }
        public string AppImageUrl { get; set; }
    }
}
