using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private MyDBContext _context;
        private MoviesViewModel model = new MoviesViewModel();

        public MoviesController()
        {
            _context = new MyDBContext();
        }
    
        public ActionResult Movies()
        {
            

            model.VideosList = _context.Videos;

            return View(model);
        }

        [HttpPost]
        public ActionResult Movies(MoviesViewModel strSearchText)
        {
            
            model.VideosList = _context.Videos.Where(s => s.titel.ToLower().Contains(strSearchText.searchMovie));

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var liste = _context.Videos.Where(v => v.v_id == id);
            return View(liste);
        }

        public ActionResult AddMovie()
        {
            
            model.KuenstlerList = _context.Kuenstler;
            model.KategorienList = _context.Kategorien;
            
            return View(model);
        }

    }
}