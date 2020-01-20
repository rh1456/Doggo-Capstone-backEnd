using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Doggo_Capstone_backEnd.Models
{
  public class EnergyLevel
  {
    public int Id { get; set; }
    public string Level { get; set; }

    [JsonIgnore]

    public List<User> User
    public List<InterestedEnergyLevel> InterestedEnergyLevels = new List<InterestedEnergyLevel>();
  }
}