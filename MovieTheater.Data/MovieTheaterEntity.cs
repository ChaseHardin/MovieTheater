using System.Data.Entity;
using MovieTheater.Data.Models;

namespace MovieTheater.Data
{
    public class MovieTheaterEntity : DbContext
    {
        public MovieTheaterEntity() : base("MovieTheaterConnectionString") { }

        public DbSet<Movie> Movies { get; set; }
    }
}