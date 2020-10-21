using System.Collections.Generic;
using System.Linq;
using movieApi.Models;

namespace movieApi.Data
{
    public class SqlMovieRepo : IMovieRepo
    {
        private readonly MovieContext _context;

        public SqlMovieRepo(MovieContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> getAllMovies()
        {
           return _context.Movies.ToList();
        }

        public Movie getById(int id)
        {
            return _context.Movies.FirstOrDefault(p => p.Id == id);
        }
    }
}