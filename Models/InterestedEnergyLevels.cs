using System.Collections.Generic;
using Newtonsoft.Json;

namespace Doggo_Capstone_backEnd.Models
{
  public class InterestedEnergyLevel
  {
    public int Id { get; set; }
    public string InterestedIn { get; set; }

    public int EnergyLevelId { get; set; }
    public EnergyLevel EnergyLevel { get; set; }

    [JsonIgnore]
    public List<User> Users { get; set; }

  }
}