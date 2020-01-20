using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;


namespace Doggo_Capstone_backEnd.Models
{
  public class Gender
  {
    public int Id { get; set; }
    [Required]
    public string Sex { get; set; }

    public List<User> Users { get; set; } = new List<User>();

  }
}