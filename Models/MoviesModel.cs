using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Models
{
    public class MoviesModel
    {
        public IEnumerable<Videos> Videos { get; set; }

        public IEnumerable<SelectListItem> Kategorien { get; set; }

        public IEnumerable<SelectListItem> Kuenstler { get; set; }
        public string searchMovie { get; set; }
    }
}