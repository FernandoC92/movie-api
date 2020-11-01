using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using movieApi.Data;
using movieApi.Dtos;

namespace movieApi.Controllers
{   
    [Route("api/query")]
    [ApiController]
    public class MovieControllerSearch : ControllerBase
    {
        private readonly IMovieRepo _repository;
        private readonly IMapper _mapper;

        public MovieControllerSearch(IMovieRepo repositiry, IMapper mapper)
        {
            _repository = repositiry;
            _mapper = mapper;
        }
        
        [EnableCors("PolicyMovieApi")]
        [HttpGet("{query}")]
        public ActionResult<MovieReadListDto> getByName(string query) {
            var movies = _repository.getByName(query);
            if (movies != null)
            {
                return Ok(_mapper.Map<IEnumerable<MovieReadListDto>>(movies));
            }
            return NotFound();
        }

    }
}