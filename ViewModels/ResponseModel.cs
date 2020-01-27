using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItunesSearcher.ViewModels
{
    public class ResponseModel
    {
        public string Message { get; set; }
        public object Data { get; set; } = new { };
        public bool AppAdded { get; set; } = false;
    }
}
