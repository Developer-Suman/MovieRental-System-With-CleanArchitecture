using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly IMovieServices _services;
        public MoviesController(IMovieServices movieServices)
        {
            _services = movieServices;
        }

       

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movieFromServices = _services.GetAllMovies();
            return Ok(movieFromServices);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovies(Movie movie)
        {
            var Movie = _services.CreateMovie(movie);
            return Ok(Movie);

        }

        
    }
}
