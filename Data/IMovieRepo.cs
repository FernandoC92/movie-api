using System.Collections.Generic;
using movieApi.Models;

namespace movieApi.Data
{
    public interface IMovieRepo
    {   
        bool SaveChanges();
        IEnumerable<Movie> getAllMovies();
        Movie getById(int id);
        void CreateMovie(Movie movie);
    }
}