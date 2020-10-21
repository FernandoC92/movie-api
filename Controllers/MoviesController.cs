using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using movieApi.Data;
using movieApi.Models;

namespace movieApi.Controllers
{   
    
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepo _repository;

        public MoviesController(IMovieRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAllMovies() {
            var movies = _repository.getAllMovies();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieById(int id) {
            var movie = _repository.getById(id);
            return Ok(movie);
        }

        // * DbContext
        // * Repository
        // * Get All Movies
        // * Get Movie by Id
    }
}