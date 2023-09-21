using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieServices : IMovieServices
    {
        //Constructor Dependency injection
        private readonly IMovieRepository _movieRepository;
     
        public MovieServices(IMovieRepository movieRepository)
        {

            _movieRepository = movieRepository;

        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
