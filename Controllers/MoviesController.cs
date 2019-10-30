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
        

        public MoviesController()
        {
            _context = new MyDBContext();
        }
    
        public ActionResult Movies()
        {
            var model = new MoviesViewModel
            {
                VideosList = _context.Videos
            };

            

            return View(model);
        }

        [HttpPost]
        public ActionResult Movies(MoviesViewModel strSearchText)
        {
            var model = new MoviesViewModel
            {
                VideosList = _context.Videos.Where(s => s.titel.ToLower().Contains(strSearchText.searchMovie))
            };
            
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var liste = _context.Videos.Where(v => v.v_id == id);
            return View(liste);
        }

        public ActionResult SaveMovie(int id)
        {
            var viewModel = new MoviesViewModel();
            if (id <= 0)
            {
                viewModel.KuenstlerList = _context.Kuenstler;
                viewModel.KategorienList = _context.Kategorien;
                viewModel.ViewTitel = "Add new Movie";

                return View(viewModel);
            }
            else
            {

                viewModel.Videos = _context.Videos.Single(v => v.v_id == id);
                viewModel.KuenstlerList = _context.Kuenstler;
                viewModel.KategorienList = _context.Kategorien;
                viewModel.ViewTitel = "Edit this Movie";

                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult SaveMovie(MoviesViewModel formPosts)
        {
            if(formPosts.Videos.v_id == 0)
            {
                _context.Videos.Add(formPosts.Videos);
                _context.SaveChanges();

                return Redirect("Movies");
            }
            else
            {
                var videoInDb = _context.Videos.Single(v => v.v_id == formPosts.Videos.v_id);

                videoInDb.album = formPosts.Videos.album;
                videoInDb.anmerkung = formPosts.Videos.anmerkung;
                videoInDb.benotung = formPosts.Videos.benotung;
                videoInDb.dateigroesse = formPosts.Videos.dateigroesse;
                videoInDb.erscheinungsjahr = formPosts.Videos.erscheinungsjahr;
                videoInDb.fk_a_id = formPosts.Videos.fk_a_id;
                videoInDb.fk_k_id = formPosts.Videos.fk_k_id;
                videoInDb.qualitaet = formPosts.Videos.qualitaet;
                videoInDb.titel = formPosts.Videos.titel;


                _context.SaveChanges();

                return Redirect("Movies");
            }
        }

    }
}