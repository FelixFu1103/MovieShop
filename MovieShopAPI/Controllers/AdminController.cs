using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IUserService _userService;

        public AdminController(IMovieService movieService, IUserService userService)
        {
            _movieService = movieService;
            _userService = userService;
        }

        //CreateMovieController
        [HttpPost("movie")]
        public async Task<IActionResult> CreateMovie([FromBody] CreateMovieRequestModel createMovieRequestModel)
        {
            var createdMovie = await _movieService.CreateMovie(createMovieRequestModel);
            return CreatedAtRoute("GetMovie", new { id = createdMovie.Id }, createdMovie);
        }
        //UpdateMovieController
        [HttpPut("movie")]
        public async Task<IActionResult> UpdateMovie([FromBody] CreateMovieRequestModel createMovieRequestModel)
        {
            var createdMovie = await _movieService.UpdateMovie(createMovieRequestModel);
            return CreatedAtRoute("GetMovie", new { id = createdMovie.Id }, createdMovie);
        }
        //GetPurchasesController
        [HttpGet("purchases")]
        public async Task<IActionResult> GetPurchases([FromQuery] PurchaseModel purchaseModel)
        {
            var movies = await _movieService.GetMoviePurchases(purchaseModel);
            return Ok(movies);
        }
    }
}