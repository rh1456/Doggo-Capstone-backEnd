using System.Collections.Generic;


namespace Doggo_Capstone_backEnd.Models
{
  public class InterestedEnergyLevel
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public User user { get; set; }
    public int EnergyLevelId { get; set; }
    public EnergyLevel EnergyLevel { get; set; }



  }
}