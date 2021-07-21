using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieRepository : IAsyncRepository<Movie>
    {
        Task<List<Movie>> GetHighest30GrossingMovies();
        Task<List<Movie>> GetAll();
        Task<List<Movie>> GetTop30RatedMovies();
        Task<List<Review>> GetReviewByMovie(int id);
    }
}