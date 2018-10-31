using Microsoft.EntityFrameworkCore;
using System;

namespace RazorPagesMovies.Models
{
    public class RazorPagesMoviesContext : DbContext
    {
        public RazorPagesMoviesContext(DbContextOptions<RazorPagesMoviesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //this is another way to seed the database
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    ID = 1,
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Movie
                {
                    ID = 2,
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "R"
                },
                new Movie
                {
                    ID = 3,
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "R"
                },
                new Movie
                {
                    ID = 4,
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "R"
                });
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

