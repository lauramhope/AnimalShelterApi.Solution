﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20230609154710_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Breed = "Pitbull",
                            Name = "Ginger",
                            Species = "Canine"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 4,
                            Breed = "Maine Coon",
                            Name = "Momo",
                            Species = "Feline"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 7,
                            Breed = "German Shepherd",
                            Name = "Appa",
                            Species = "Canine"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "Chihuahua",
                            Name = "Taco",
                            Species = "Canine"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 11,
                            Breed = "Ragdoll",
                            Name = "Tuna",
                            Species = "Feline"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
