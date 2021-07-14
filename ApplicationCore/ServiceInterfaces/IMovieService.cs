using System;
using System.Collections.Generic;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
       List<MovieCardResponseModel> GetTopRevenueMovies();
    }
}
