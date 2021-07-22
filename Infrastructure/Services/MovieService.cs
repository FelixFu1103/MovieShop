
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{

    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<List<MovieCardResponseModel>> GetTopRevenueMovies()
        {
            var movies = await _movieRepository.GetHighest30GrossingMovies();

            var movieCards = new List<MovieCardResponseModel>();

            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel { Id = movie.Id, Budget = movie.Budget.GetValueOrDefault(), PosterUrl = movie.PosterUrl, Title = movie.Title });
            }

            return movieCards;
        }

        public async Task<List<MovieCardResponseModel>> GetTopRatedMovies()
        {
            var movies = await _movieRepository.GetTop30RatedMovies();

            var movieCards = new List<MovieCardResponseModel>();

            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel { Id = movie.Id, Budget = movie.Budget.GetValueOrDefault(), PosterUrl = movie.PosterUrl, Title = movie.Title });
            }

            return movieCards;
        }

     

        public async Task<List<MovieCardResponseModel>> GetMovies()
        {
            var movies = await _movieRepository.GetAll();
            var movieCards = new List<MovieCardResponseModel>();

            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel { Id = movie.Id, Budget = movie.Budget.GetValueOrDefault(), PosterUrl = movie.PosterUrl, Title = movie.Title });
            }

            return movieCards;
        }

        public async Task<MovieDetailsResponseModel> GetMovieDetails(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);

            var movieDetails = new MovieDetailsResponseModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Budget = movie.Budget.GetValueOrDefault(),
                TmdbUrl = movie.TmdbUrl,
                BackdropUrl = movie.BackdropUrl,
                Tagline = movie.Tagline,
                PosterUrl = movie.PosterUrl,
                ReleaseDate = movie.ReleaseDate,
                RunTime = movie.RunTime,
                Revenue = movie.Revenue,
                Rating = movie.Rating,
                Overview = movie.Overview,
                Price = movie.Price
            };

            movieDetails.Casts = new List<CastResponseModel>();

            foreach (var cast in movie.MovieCasts)
            {
                movieDetails.Casts.Add(new CastResponseModel
                {
                    Id = cast.CastId,
                    Name = cast.Cast.Name,
                    Character = cast.Character,
                    Gender = cast.Cast.Gender,
                    TmdbUrl = cast.Cast.TmdbUrl,
                    ProfilePath = cast.Cast.ProfilePath
                });
            }

            movieDetails.Genres = new List<GenreModel>();
            foreach (var genre in movie.Genres)
            {
                movieDetails.Genres.Add(
                    new GenreModel
                    {
                        Id = genre.Id,
                        Name = genre.Name
                    }
                    );
            }

            return movieDetails;
        }

        public async Task<List<MovieCardResponseModel>> GetMoviesByGenreId(int id)
        {
            var genre = await _movieRepository.GetByIdAsync(id);

            if (genre == null)
            {
                return null;
            }

            var genreMovie = new List<MovieCardResponseModel>();

            foreach (var movieGenre in genre.Genres)
            {
                genreMovie.Add(new MovieCardResponseModel
                {
                    Id = movieGenre.Id,
                    Title = genre.Title,
                    PosterUrl = genre.PosterUrl,
                    Budget = (decimal)genre.Budget,

                });
            }

            return genreMovie;
        }

        public async Task<List<ReviewResponseModel>> GetReviewsByMovie(int id)
        {
            var reviews = await _movieRepository.GetReviewByMovie(id);
            var reviewCards = new List<ReviewResponseModel>();

            foreach (var review in reviews)
            {
                reviewCards.Add(new ReviewResponseModel
                {
                    MovieId = review.MovieId,
                    UserId = review.UserId,
                    ReviewText = review.ReviewText,
                    Rating = review.Rating
                });

            }

            return reviewCards;
        }

        public async Task<MovieDetailsResponseModel> CreateMovie(CreateMovieRequestModel createMovieRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<MovieDetailsResponseModel> UpdateMovie(CreateMovieRequestModel createMovieRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<PurchaseModel> GetMoviePurchases(PurchaseModel purchaseResponseModel)
        {
            throw new NotImplementedException();
        }
    }

}