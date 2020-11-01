using System.Collections.Generic;
using movieApi.Models;

namespace movieApi.Data
{
    public interface IMovieRepo
    {   
        bool SaveChanges();
        IEnumerable<Movie> getAllMovies();
        Movie getById(int id);
        IEnumerable<Movie> getByName(string searchString);
        void CreateMovie(Movie movie);

    }
}