using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        Task<List<MovieCardResponseModel>> GetTopRevenueMovies();
        Task<MovieDetailsResponseModel> GetMovieDetails(int id);
        Task<List<MovieCardResponseModel>> GetMovies();
        Task<List<MovieCardResponseModel>> GetTopRatedMovies();
        Task<List<MovieCardResponseModel>> GetMoviesByGenreId(int id);
        Task<List<ReviewResponseModel>> GetReviewsByMovie(int id);
    }
}