using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;

        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }

        public async Task<CastDetailsResponseModel> GetCastDetails(int id)
        {
            var cast = await _castRepository.GetByIdAsync(id);

            var castDetail = new CastDetailsResponseModel()
            {
                Id = cast.Id,
                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
            };

            castDetail.Movies = new List<MovieCardResponseModel>();

            foreach (var movie in cast.MovieCasts)
            {
                castDetail.Movies.Add(new MovieCardResponseModel()
                {
                    Id = movie.Movie.Id,
                    Budget = movie.Movie.Budget.GetValueOrDefault(),
                    PosterUrl = movie.Movie.PosterUrl,
                    Title = movie.Movie.Title
                });
            }

            return castDetail;
        }
    }
}
