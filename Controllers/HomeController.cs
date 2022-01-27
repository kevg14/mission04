using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission04.Models;

namespace mission04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext Important)
        {
            _logger = logger;
            _blahContext = Important;
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult MovieApplication(MovieResponse ar)
        {
            //checks to see if submit is valid if so to submit
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();
                return View("Confirmation");
            }
            else
            {
                return View(ar);

            }

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


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
