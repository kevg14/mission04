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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId = 1,
                    category = "Action/Adventure",
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
                    category = "Drama",
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
                    category = "Family",
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
