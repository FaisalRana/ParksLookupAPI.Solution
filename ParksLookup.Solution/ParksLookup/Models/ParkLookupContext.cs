using Microsoft.EntityFrameworkCore;

namespace ParkLookup.Models {
  public class ParkLookupContext : DbContext {
    public ParkLookupContext(DbContextOptions<ParkLookupContext> options)
        : base(options) {
    }

    public DbSet<Park> Parks { get; set; }
    protected override void OnModelCreating(ModelBuilder builder) {
      builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, Name = "Himalaya National Park", Established = 2020, Province = "GB"},
              new Park { ParkId = 2, Name = "Hundrap-Shandur National Park", Established = 2012, Province = "GB"},
              new Park { ParkId = 3, Name = "Nanga-Parbat National Park", Established = 2010, Province = "GB"},
              new Park { ParkId = 4, Name = "Broghil Valley", Established = 1993, Province = "KP"},
              new Park { ParkId = 5, Name = "Central Karakoram", Established = 1987, Province = "GB"}
        );
    }
  }
}

// here we are adding objects to our database without having to manually enter each one. 
// we are using a ovveriding method "OnModelCreating" that comes from our base class DBCONTEXT
// the onmodelcreating takes a builder argument