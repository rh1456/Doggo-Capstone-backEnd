using System.ComponentModel.DataAnnotations;


namespace Doggo_Capstone_backEnd.Models
{
  public class Gender
  {
    public int Id { get; set; }
    [Required]
    public string Sex { get; set; }
  }
}