using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Doggo_Capstone_backEnd.Models
{
  public partial class DatabaseContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<EnergyLevel> EnergyLevels { get; set; }
    public DbSet<InterestedEnergyLevel> InterestedEnergyLevels { get; set; }
    public DbSet<Gender> Genders { get; set; }

    private string ConvertPostConnectionToConnectionString(string connection)
    {
      var _connection = connection.Replace("postgres://", String.Empty);
      var output = Regex.Split(_connection, ":|@|/");
      return $"server={output[2]};database={output[4]};User Id={output[0]}; password={output[1]}; port={output[3]}";
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Gender>().HasData(
     new Gender { Id = 1, Sex = "Male" },
     new Gender { Id = 2, Sex = "Female" }
     );
      new EnergyLevel { Id = 1, Level = "Very SHy" },
      new EnergyLevel { Id = 2, Level = "Shy" },
      new EnergyLevel { Id = 3, Level = "Friendly" },
      new EnergyLevel { Id = 4, Level = "Aggressive" }
      );

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        var envConn = Environment.GetEnvironmentVariable("DATABASE_URL");
        // #warning Update this connection string to point to your own database.
        var conn = "server=localhost;database=Doggo_Capstone_backEndDatabase";
        if (envConn != null)
        {
          conn = ConvertPostConnectionToConnectionString(envConn);
        }
        optionsBuilder.UseNpgsql(conn);
      }
    }



  }
}
