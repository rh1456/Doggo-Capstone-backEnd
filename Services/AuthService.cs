using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Doggo_Capstone_backEnd.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Doggo_Capstone_backEnd.Services
{
  public class AuthService
  {

    private readonly string KEY;

    public AuthService(IConfiguration configuration)
    {
      KEY = configuration["JWT-KEY"];
    }

    public AuthenticatedData CreateToken(Models.User user)
    {
      var expirationTime = DateTime.UtcNow.AddHours(10);

      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new[]
        {
            new Claim("id", user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.NameIdentifier, user.Username)

      }),
        Expires = expirationTime,
        SigningCredentials = new SigningCredentials(
               new SymmetricSecurityKey(Encoding.ASCII.GetBytes(this.KEY)),
              SecurityAlgorithms.HmacSha256Signature
          )
      };
      var tokenHandler = new JwtSecurityTokenHandler();
      var token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
      return new AuthenticatedData
      {
        FullName = user.FullName,
        Token = token,
        UserId = user.Id,
        Username = user.Username,
        ExpirationTime = expirationTime
      }; ;
    }
  }
}