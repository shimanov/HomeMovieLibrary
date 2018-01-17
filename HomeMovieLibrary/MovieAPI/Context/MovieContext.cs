using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.Context
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {

        }
    }
}
