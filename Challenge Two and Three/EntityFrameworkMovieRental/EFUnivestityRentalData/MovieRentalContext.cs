using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EFMovieRentalDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivestityRentalData
{
    public class MovieRentalContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-KAP3NP1H; Initial Catalog=MovieRental; persist security info=True; Integrated Security=SSPI;")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();  //to use sql server, connection string

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ADD VALIDATION TO OUR TABLES
            // ----- Varchar ------
            // Movie
            modelBuilder.Entity<Movie>().Property(p => p.Title).HasMaxLength(35);
            modelBuilder.Entity<Movie>().Property(p => p.Description).HasMaxLength(100);
            modelBuilder.Entity<Movie>().Property(p => p.TrailerLink).HasMaxLength(500);
            // Tag
            modelBuilder.Entity<Tag>().Property(p => p.Name).HasMaxLength(35);

            // ----- Index ------
            modelBuilder.Entity<Movie>().HasIndex(h => h.Title);
            modelBuilder.Entity<Tag>().HasIndex(h => h.Name).IsUnique();
            modelBuilder.Entity<Movie>().HasIndex(h => h.SalePrice);

            //SEEDING DATA
            // Movies
            modelBuilder.Entity<Movie>().HasData(
                    new Movie { Id = 1, Title = "Avengers", Description = "Marvel Studios Avenger", PosterStock = 5, TrailerLink="Avengers.com", SalePrice = 10.52, Likes = 80},
                    new Movie { Id = 2, Title = "Avengers 2", Description = "Marvel Studios Avenger", PosterStock = 4, TrailerLink = "Avengers.com", SalePrice = 13.52, Likes = 90 },
                    new Movie { Id = 3, Title = "El origen", Description = "Dicaprio el origen", PosterStock = 3, TrailerLink = "ELROGINE.COM", SalePrice = 12.52, Likes = 50 },
                    new Movie { Id = 4, Title = "Nemo", Description = "Nemo nemo", PosterStock = 4, TrailerLink = "Nemo.com", SalePrice = 9.52, Likes = 70 }
            );
            // Tags
            modelBuilder.Entity<Tag>().HasData(
                   new Tag { Id = 1, Name = "Accion" },
                   new Tag { Id = 2, Name = "Comedia" },
                   new Tag { Id = 3, Name = "Niños" },
                   new Tag { Id = 4, Name = "Suspenso" },
                   new Tag { Id = 5, Name = "Misiones" },
                   new Tag { Id = 6, Name = "Animadas" }
           );
            // Movie Tag
            modelBuilder.Entity<MovieTag>().HasData(
                   new MovieTag { Id = 1, MovieId = 1, TagId = 1},
                   new MovieTag { Id = 2, MovieId = 1, TagId = 2 },
                   new MovieTag { Id = 3, MovieId = 2, TagId = 1 },
                   new MovieTag { Id = 4, MovieId = 2, TagId = 2 },
                   new MovieTag { Id = 5, MovieId = 3, TagId = 3 },
                   new MovieTag { Id = 6, MovieId = 4, TagId = 6 }
           );

        }


        public DbSet<Movie> Movies { get; set; }  //set or rules of reading a table
        public DbSet<Tag> Tags { get; set; }  //set or rules of reading a table
        public DbSet<MovieTag> MovieTags { get; set; }  //set or rules of reading a table
    }
}
