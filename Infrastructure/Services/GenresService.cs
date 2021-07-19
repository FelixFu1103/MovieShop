using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Infrastructure.Services
{
    public class GenresService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenresService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<IEnumerable<GenreModel>> GetAllGenres()
        {
            var genres = await _genreRepository.ListAllAsync();
            var genreList = new List<GenreModel>();
            foreach (var genre in genres)
            {
                genreList.Add(new GenreModel()
                {
                    Id = genre.Id,
                    Name = genre.Name,
                });
            }
            return genreList;
        }

        public async Task<GenreDetailsResponseModel> GetGenreDetails(int id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);
            Debug.WriteLine("genre");
            Debug.WriteLine(genre);
            var genreMovies = new GenreDetailsResponseModel()
            {
                Id = genre.Id,
                Name = genre.Name,
            };
            
            genreMovies.Movies = new List<MovieCardResponseModel>();

            foreach (var movie in genre.Movies)
            {
                genreMovies.Movies.Add(new MovieCardResponseModel()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl,
                    Budget = movie.Budget.GetValueOrDefault(),
                });
            }

            return genreMovies;
        }
    }
}
