﻿// <auto-generated />
using System;
using FlixMaster.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlixMaster.Migrations
{
    [DbContext(typeof(FlixMasterContext))]
    [Migration("20200806163524_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FlixMaster.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Genre");

                    b.Property<string>("Rating");

                    b.Property<string>("Title");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("FlixMaster.Models.MovieShowing", b =>
                {
                    b.Property<int>("MovieShowingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MovieId");

                    b.Property<int>("ShowingId");

                    b.HasKey("MovieShowingId");

                    b.HasIndex("MovieId");

                    b.HasIndex("ShowingId");

                    b.ToTable("MovieShowing");
                });

            modelBuilder.Entity("FlixMaster.Models.Showing", b =>
                {
                    b.Property<int>("ShowingId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ShowingDate");

                    b.Property<DateTime>("ShowingTime");

                    b.HasKey("ShowingId");

                    b.ToTable("Showings");
                });

            modelBuilder.Entity("FlixMaster.Models.MovieShowing", b =>
                {
                    b.HasOne("FlixMaster.Models.Movie", "Movie")
                        .WithMany("Showings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FlixMaster.Models.Showing", "Showing")
                        .WithMany("Movies")
                        .HasForeignKey("ShowingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
