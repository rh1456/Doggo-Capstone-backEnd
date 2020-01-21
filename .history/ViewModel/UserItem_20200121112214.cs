using System;

namespace Doggo_Capstone_backEnd.ViewModels
{
  public class UserItem
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string About { get; set; }
    public string Breed { get; set; }
    public string Size { get; set; }
    public string Sex { get; set; }
    public string Level { get; set; }

    public string InterestLevel { get; set; }
  }
}