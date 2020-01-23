using System;

namespace Doggo_Capstone_backEnd.ViewModels
{
  public class AuthenticatedData
  {
    public string Username { get; set; }
    public int UserId { get; set; }
    public string FullName { get; set; }
    public string Token { get; set; }
    public DateTime ExpirationTime { get; set; }
  }
}