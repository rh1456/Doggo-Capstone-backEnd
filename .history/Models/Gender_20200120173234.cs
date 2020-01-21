using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Doggo_Capstone_backEnd.Models
{
  public class Gender
  {
    public int Id { get; set; }
    public string Sex { get; set; }

    [JsonIgnore]
    public List<User> Users { get; set; }
  }
}