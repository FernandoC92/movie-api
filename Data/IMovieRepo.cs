using System.Collections.Generic;
using movieApi.Models;

namespace movieApi.Data
{
    public interface IMovieRepo
    {
        IEnumerable<Movie> getAllMovies();
        Movie getById(int id);
    }
}