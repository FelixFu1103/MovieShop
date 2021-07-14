using System;
using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieRepository
    {
       List<Movie> GetHighest30GrossingMovies();
        // 10 methods
    }
}
