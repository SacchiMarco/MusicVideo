using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MoviesModel
    {
        public IEnumerable<Videos> Videos { get; set; }
        public string searchMovie { get; set; }
    }
}