using AutoMapper;
using movieApi.Models;

namespace movieApi.Dtos
{
    public class MoviesProfile : Profile
    {
        public MoviesProfile()
        {
            CreateMap<Movie, MovieReadDto>();
            CreateMap<Movie, MovieReadListDto>();
            CreateMap<MovieCreateDto, Movie>();

        }
    }
}