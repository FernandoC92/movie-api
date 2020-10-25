using System;
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

        public void CreateMovie(Movie movie)
        {   
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }
            _context.Add(movie);
        }

        public IEnumerable<Movie> getAllMovies()
        {
           return _context.Movies.ToList();
        }

        public Movie getById(int id)
        {
            return _context.Movies.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}