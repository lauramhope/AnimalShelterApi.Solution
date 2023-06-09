using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Ginger", Species = "Canine", Breed = "Pitbull", Age = 2 },
          new Animal { AnimalId = 2, Name = "Momo", Species = "Feline", Breed = "Maine Coon", Age = 4 },
          new Animal { AnimalId = 3, Name = "Appa", Species = "Canine", Breed = "German Shepherd", Age = 7 },
          new Animal { AnimalId = 4, Name = "Taco", Species = "Canine", Breed = "Chihuahua", Age = 4 },
          new Animal { AnimalId = 5, Name = "Tuna", Species = "Feline", Breed = "Ragdoll", Age = 11 }
        );
    }
  }
}