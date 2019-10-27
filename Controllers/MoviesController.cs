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
        private MoviesModel model = new MoviesModel();

        public MoviesController()
        {
            _context = new MyDBContext();
        }
    
        public ActionResult Movies()
        {
            

            model.Videos = _context.Videos;

            return View(model);
        }

        [HttpPost]
        public ActionResult Movies(MoviesModel strSearchText)
        {
            
            model.Videos = _context.Videos.Where(s => s.titel.ToLower().Contains(strSearchText.searchMovie));

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var liste = _context.Videos.Where(v => v.v_id == id);
            return View(liste);
        }

        public ActionResult AddMovie()
        {
            var videos = new List<Videos>();
            model.Videos = videos;
            model.Kuenstler = selectListCreatKuenstler(_context.Kuenstler);
            model.Kategorien = selectListCreatKategorien(_context.Kategorien);
            
            return View(model);
        }


        public IEnumerable<SelectListItem> selectListCreatKuenstler(IEnumerable<Kuenstler> items)
        {
            IEnumerable<SelectListItem> ListItems;
            ListItems = items
                .Select(i => new SelectListItem()
                {

                    Text = i.k_name,
                    Value = i.k_id.ToString(),
                    Selected = false
                })
                .ToList();

            return ListItems;
        }

        public IEnumerable<SelectListItem> selectListCreatKategorien(IEnumerable<Kategorien> items)
        {
            IEnumerable<SelectListItem> ListItems;
            ListItems = items
                .Select(i => new SelectListItem()
                {

                    Text = i.a_name,
                    Value = i.a_id.ToString(),
                    Selected = false
                })
                .ToList();

            return ListItems;
        }
    }
}