using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }
    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void
    OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>().HasData(
        new Destination { DestinationId = 1, Country = "Switzerland", City = "Zurich", Review = "Great", Rating = 5, UserName = "MollyRD" },
        new Destination { DestinationId = 2, Country = "Japan", City = "Osaka", Review = "Excellent", Rating = 1, UserName = "EliotLG" },
        new Destination { DestinationId = 3, Country = "Sweden", City = "Stockholm", Review = "Meh", Rating = 10, UserName = "JakeM" },
        new Destination { DestinationId = 4, Country = "Mexico", City = "Mexico City", Review = "Awesome", Rating = 10, UserName = "JakeM" },
        new Destination { DestinationId = 5, Country = "England", City = "Oxford", Review = "Brilliant", Rating = 4, UserName = "EliotLG" }
      );
    }
  }
}