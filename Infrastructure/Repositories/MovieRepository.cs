using System;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetHighest30GrossingMovies()
        {
            throw new NotImplementedException();
        }
    }
}
