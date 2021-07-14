using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieShopMVC.Models;
using Infrastructure.Services;
using ApplicationCore.ServiceInterfaces;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        // Each and every rwqeust in MVC controller
        // localhost/home/index

        // 1. *** Contsructor Injection 99.99% **
        // 2. Method Injection
        // 3. Property Injection

        private readonly IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {

            var movies = _movieService.GetTopRevenueMovies();

            var myType = movies.GetType();

            // 3 ways to send the data from Controller/action to View
            // 1.*** Models (strongly typed models)
            // 2. ViewBag
            // 3. ViewData

            ViewBag.MoviesCount = movies.Count();

            return View(movies);
        }
                

        // HomeController   
        // MovieController       MovieService
        // UserController
        // newing up


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
