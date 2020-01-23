
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Doggo_Capstone_backEnd.Models

{
  public class User
  {
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string HashedPassword { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public string About { get; set; }
    public string Size { get; set; }
    public int EnergyLevelId { get; set; }
    public EnergyLevel EnergyLevel { get; set; }

    public int GenderId { get; set; }
    public Gender Gender { get; set; }

    public int InterestedEnergyLevelId { get; set; }
    public InterestedEnergyLevel InterestedEnergyLevel { get; set; }

  }
}