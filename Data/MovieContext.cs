using movieApi.Models;
using Microsoft.EntityFrameworkCore;

namespace movieApi.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies {get; set;}
    }
}