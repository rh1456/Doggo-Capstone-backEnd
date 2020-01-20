using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Doggo_Capstone_backEnd.Models;
using Doggo_Capstone_backEnd.ViewModels;

namespace Doggo_Capstone_backEnd.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class UserController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAllUsers()
    {
      var db = new DatabaseContext();
      return Ok(db.Users.OrderBy(o => o.Id));

    }
    [HttpGet("{id}")]
    public ActionResult GetOneUser(int id)
    {
      var db = new DatabaseContext();
      var user = db.Users.FirstOrDefault(f => f.Id == id);
      if (user == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(user);
      }
    }
    [HttpPost]
    public ActionResult CreateUser(NewUserViewModel vm)
    {
      var db = new DatabaseContext();
      var energyLevel = db.EnergyLevels.OrderBy(el => el.Id == vm.EnergyLevelId);
      if (energyLevel == null)
      {
        return BadRequest();
      }
      else
      {
        var newUser = new User
        {
          Name = vm.Name,
          Breed = vm.Breed,
          About = vm.About,
          GenderId = vm.GenderId,
          Size = vm.Size,
          EnergyLevelId = vm.EnergyLevelId
        };
        db.Users.Add(newUser);
        db.SaveChanges();
        var rv = new CreatedUser
        {
          Id = newUser.Id,
          Name = newUser.Name,
          Breed = newUser.Breed,
          About = newUser.About,
          Size = newUser.Size,
          GenderId = newUser.GenderId,
          EnergyLevelId = newUser.EnergyLevelId
        };
        return Ok(rv);
      }
      // var db = new DatabaseContext();
      // db.Users.Add(user);
      // db.SaveChanges();
      // return Ok(user);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateUser(int id, User user)
    {
      var db = new DatabaseContext();

      if (id != user.Id)
      {
        return BadRequest();
      }

      db.Entry<User>(user).State = EntityState.Modified;

      db.SaveChanges();

      return Ok(user);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteUser(int id)
    {
      var db = new DatabaseContext();
      var user = db.Users.FirstOrDefault(user => user.Id == id);
      if (user == null)
      {
        return NotFound();
      }
      else
      {
        db.Users.Remove(user);
        db.SaveChanges();
        return Ok();
      }
    }

  }
}