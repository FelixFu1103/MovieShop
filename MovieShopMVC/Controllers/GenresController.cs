using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MovieShopMVC.Controllers
{
    public class GenresController : Controller
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        public async Task<IActionResult> Details(int id)
        {
            Debug.WriteLine("test");
            Debug.WriteLine(id);
            var genre = await _genreService.GetGenreDetails(id);
            return View(genre);
        }
    }
}