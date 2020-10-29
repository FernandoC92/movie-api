using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using movieApi.Data;
using movieApi.Dtos;
using movieApi.Models;

namespace movieApi.Controllers
{

    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepo _repository;
        private readonly IMapper _mapper;

        public MoviesController(IMovieRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MovieReadListDto>> GetAllMovies()
        {
            var movies = _repository.getAllMovies();
            return Ok(_mapper.Map<IEnumerable<MovieReadListDto>>(movies));
        }

        [HttpGet("{id}", Name = "GetMovieById")]
        public ActionResult<MovieReadDto> GetMovieById(int id)
        {
            var movie = _repository.getById(id);
            if (movie != null)
            {
                return Ok(_mapper.Map<MovieReadDto> (movie));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<MovieReadDto> CreateMovie(MovieCreateDto movieCreateDto)
        {
            var movieModel = _mapper.Map<Movie>(movieCreateDto);
            _repository.CreateMovie(movieModel);
            _repository.SaveChanges();

            var movieReadDto = _mapper.Map<MovieReadDto>(movieModel);
            return CreatedAtRoute(nameof(GetMovieById), new { Id = movieReadDto.Id }, movieReadDto);
        }
    }
}