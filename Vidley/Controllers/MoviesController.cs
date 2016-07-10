using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;

namespace Vidley.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //return View(movie);
            //return Content("Hello there");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

        }

        public ActionResult Edit(int movieId)
        {
            return Content("Id=" + movieId);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}