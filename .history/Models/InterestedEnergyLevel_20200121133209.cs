using System.ComponentModel.DataAnnotations;
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

    public int UserId { get; set; }
    public User User { get; set; }

  }
}