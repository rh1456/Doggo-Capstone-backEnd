using System.ComponentModel.DataAnnotations;


namespace Doggo_Backend.Models
{
  public class Gender
  {
    public int Id { get; set; }
    [Required]
    public string Sex { get; set; }
  }
}