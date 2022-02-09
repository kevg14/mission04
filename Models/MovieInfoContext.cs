using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mission04.Models
{
    public class MovieInfoContext : DbContext
    {
        //Constructor
        public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base(options)
        {
            //leave blank for now
        }
        public DbSet<MovieResponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryId=1, Name = "Action/Adventure" },
                    new Category { CategoryId = 2, Name = "Comedy" },
                    new Category { CategoryId = 3, Name = "Drama" },
                    new Category { CategoryId = 4, Name = "Family" },
                    new Category { CategoryId = 5, Name = "Horror/Suspense" },
                    new Category { CategoryId = 6, Name = "Horror/Suspense" },
                    new Category { CategoryId = 7, Name = "Television" },
                    new Category { CategoryId = 8, Name = "VHS" }





                );

            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
                    title = "Spiderman:Into the Spider-Verse",
                    year = 2018,
                    director = "Peter Ramsey, Bob Persichetti, Rodney Rothman",
                    rating = "PG",
                    edited = false,
                    lent = "",
                    note = ""

                },
                new MovieResponse
                {
                    MovieId = 2,
                    CategoryId = 2,
                    title = "Shawshank Redemption, The",
                    year = 1994,
                    director = "Frank Darabont",
                    rating = "R",
                    edited = true,
                    lent = "",
                    note = ""
                },

                new MovieResponse
                {
                    MovieId = 3,
                    CategoryId = 3,
                    title = "Toy Story 3",
                    year = 2010,
                    director = "Lee Unkrich",
                    rating = "G",
                    edited = false,
                    lent = "",
                    note = ""
                }

            );
        }
    }
}
