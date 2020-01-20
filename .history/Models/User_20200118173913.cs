using System;

namespace Doggo_Capstone_backEnd.Models

{
  public class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public string About { get; set; }

    public string Size { get; set; }
    public int EnergyLevelId { get; set; }
    public EnergyLevel EnergyLevel { get; set; }

  }
}