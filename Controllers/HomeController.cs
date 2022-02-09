using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission04.Models;

namespace mission04.Controllers
{
    public class HomeController : Controller
    {
        private MovieInfoContext maContext { get; set; }

        public HomeController(MovieInfoContext Important)
        {
            maContext = Important;
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            ViewBag.Categories = maContext.Categories.ToList();

            return View();
        }

        
        [HttpPost]
        public IActionResult MovieApplication(MovieResponse ar)
        {
            ViewBag.Categories = maContext.Categories.ToList();
            //checks to see if submit is valid if so to submit
            if (ModelState.IsValid)
            {
                maContext.Add(ar);
                maContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {

                return View();

            }

        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = maContext.responses
                .Include(x => x.category)
                .ToList();
                
            return View(applications);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = maContext.Categories.ToList();

            var application = maContext.responses.Single(x => x.MovieId == movieid);

            return View("MovieApplication",application);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse Inst)
        {

                maContext.Update(Inst);
                maContext.SaveChanges();

                return RedirectToAction("MovieList");
      

        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = maContext.responses.Single(x => x.MovieId == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(MovieResponse ar)
        {
            maContext.responses.Remove(ar);
            maContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
