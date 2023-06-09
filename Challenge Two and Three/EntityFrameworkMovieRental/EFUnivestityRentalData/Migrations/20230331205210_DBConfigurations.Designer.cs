﻿// <auto-generated />
using EFUnivestityRentalData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFUnivestityRentalData.Migrations
{
    [DbContext(typeof(MovieRentalContext))]
    [Migration("20230331205210_DBConfigurations")]
    partial class DBConfigurations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFMovieRentalDomain.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Availability")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("PosterStock")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("TrailerLink")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("SalePrice");

                    b.HasIndex("Title");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = 0,
                            Description = "Marvel Studios Avenger",
                            Likes = 80,
                            PosterStock = 5,
                            SalePrice = 10.52,
                            Title = "Avengers",
                            TrailerLink = "Avengers.com"
                        },
                        new
                        {
                            Id = 2,
                            Availability = 0,
                            Description = "Marvel Studios Avenger",
                            Likes = 90,
                            PosterStock = 4,
                            SalePrice = 13.52,
                            Title = "Avengers 2",
                            TrailerLink = "Avengers.com"
                        },
                        new
                        {
                            Id = 3,
                            Availability = 0,
                            Description = "Dicaprio el origen",
                            Likes = 50,
                            PosterStock = 3,
                            SalePrice = 12.52,
                            Title = "El origen",
                            TrailerLink = "ELROGINE.COM"
                        },
                        new
                        {
                            Id = 4,
                            Availability = 0,
                            Description = "Nemo nemo",
                            Likes = 70,
                            PosterStock = 4,
                            SalePrice = 9.5199999999999996,
                            Title = "Nemo",
                            TrailerLink = "Nemo.com"
                        });
                });

            modelBuilder.Entity("EFMovieRentalDomain.MovieTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("TagId");

                    b.ToTable("MovieTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            TagId = 1
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 1,
                            TagId = 2
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 2,
                            TagId = 1
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 2,
                            TagId = 2
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 3,
                            TagId = 3
                        },
                        new
                        {
                            Id = 6,
                            MovieId = 4,
                            TagId = 6
                        });
                });

            modelBuilder.Entity("EFMovieRentalDomain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Accion"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comedia"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Niños"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Suspenso"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Misiones"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Animadas"
                        });
                });

            modelBuilder.Entity("EFMovieRentalDomain.MovieTag", b =>
                {
                    b.HasOne("EFMovieRentalDomain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFMovieRentalDomain.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Tag");
                });
#pragma warning restore 612, 618
        }
    }
}
