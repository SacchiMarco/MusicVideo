using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Models
{
    public class MoviesViewModel
    {
        public IEnumerable<Videos> VideosList { get; set; }

        public IEnumerable<Kategorien> KategorienList { get; set; }

        public IEnumerable<Kuenstler> KuenstlerList { get; set; }
        public string searchMovie { get; set; }
        public Videos Videos { get; set; }
        public Kategorien Kategorien { get; set; }
        public Kuenstler Kuenstler { get; set; }
        public string ViewTitel { get; set; }
    }
}