using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Doggo_Capstone_backEnd.Models
{
  public class EnergyLevel
  {
    public int Id { get; set; }
    public string Level { get; set; }

    // public int InterestedEnergyLevelId { get; set; }
    // public InterestedEnergyLevel InterestedEnergyLevel { get; set; }

    // [JsonIgnore]
    // public List<User> Users { get; set; } = new List<User>();
    [JsonIgnore]
    public List<InterestedEnergyLevel> InterestedEnergyLevels { get; set; } = new List<InterestedEnergyLevel>();
  }
}