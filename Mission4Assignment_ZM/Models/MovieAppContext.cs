using System;
using Microsoft.EntityFrameworkCore;

namespace Mission4Assignment_ZM.Models
{
    public class MovieAppContext : DbContext
    {
        //contstructor
        public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options)
        {
            //leave blank for now= this is inheritance!
        }

        //responses= data set (list of data from the database)
        public DbSet<MovieAdd> Responses { get; set; }

        //THIS IS FOR SEEDING
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // see if data doesn't exist
            mb.Entity<MovieAdd>().HasData(
                new MovieAdd
                {
                    Title = "Inception",
                    Category = "Action",
                    Year = "2010",
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Best Movie EVER!"
                },
                new MovieAdd
                {
                    Title = "Rudy",
                    Category = "Drama",
                    Year = "1993",
                    Director = "David Anspaugh",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Gave me chills"
                },
                new MovieAdd
                {
                    Title = "The Lion King",
                    Category = "Family",
                    Year = "1994",
                    Director = "Roger Allers",
                    Rating = "G",
                    Edited = false,
                    LentTo = "",
                    Notes = "SO inspirational"
                }
            );
        }
    }
}
