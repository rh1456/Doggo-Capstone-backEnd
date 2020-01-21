// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Doggo_Capstone_backEnd.Models;
// using Doggo_Capstone_backEnd.ViewModels;


// namespace Doggo_Capstone_backEnd.Controllers
// {
//   [Route("api/[controller]")]
//   [ApiController]
//   public class UserController : ControllerBase
//   {
//     private readonly DatabaseContext _context;

//     public UserController(DatabaseContext context)
//     {
//       _context = context;
//     }

//     // GET: api/User
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<User>>> GetUsers()
//     {
//       var db = new DatabaseContext();
//       var userResults = db.Users.Include(i => i.EnergyLevel).Include(i => i.Gender);
//       var rv = userResults.Select(user => new UserItem
//       {
//         Id = user.Id,
//         Name = user.Name,
//         Breed = user.Breed,
//         About = user.About,
//         Size = user.Size,
//         Level = user.EnergyLevel.Level,
//         Sex = user.Gender.Sex
//       });
//       return Ok(rv);
//     }

//     // GET: api/User/5
//     [HttpGet("{id}")]
//     public async Task<ActionResult<User>> GetUser(int id)
//     {
//       var db = new DatabaseContext();
//       var userResults = db.Users.Include(i => i.EnergyLevel).Include(i => i.Gender).FirstOrDefault(f => f.Id == id);
//       var rv = new UserItem
//       {
//         Id = userResults.Id,
//         About = userResults.About,
//         Name = userResults.Breed,
//         Size = userResults.Size,
//         Level = userResults.EnergyLevel.Level,
//         Sex = userResults.Gender.Sex
//       };
//       return Ok(rv);
//     }

//     //   if (userResultsel == null)
//     //   {
//     //     return NotFound();
//     //   }
//     //   else if (userResultsG== null)
//     //   {
//     //     return NotFound();
//     //   }
//     //  else 
//     //   {
//     //     return Ok(userResultsEl);
//     //     return Ok(userResultsG);
//     //   }
//     // }
//     // var user = await _context.Users.FindAsync(id);

//     // if (user == null)
//     // {
//     //   return NotFound();
//     // }
//     // var db = new DatabaseContext();
//     //     var userResults = db.Users.Include(i => i.EnergyLevel).Include(i => i.Gender);
//     //     // var userResultsG = db.Users.Include(i => i.Gender).FirstOrDefault(f => f.Id == id);
//     //     var rv = userResults.Select(user => new UserItem
//     //     {
//     //       Id = user.Id,
//     //       Name = user.Name,
//     //       Breed = user.Breed,
//     //       About = user.About,
//     //       Size = user.Size,
//     //       Level = user.EnergyLevel.Level,
//     //       Sex = user.Gender.Sex
//     //     });
//     //     return Ok(rv);
//     // return user;


//     // PUT: api/User/5
//     // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//     // more details see https://aka.ms/RazorPagesCRUD.
//     [HttpPut("{id}")]
//     public async Task<IActionResult> PutUser(int id, User user)
//     {
//       if (id != user.Id)
//       {
//         return BadRequest();
//       }

//       _context.Entry(user).State = EntityState.Modified;

//       try
//       {
//         await _context.SaveChangesAsync();
//       }
//       catch (DbUpdateConcurrencyException)
//       {
//         if (!UserExists(id))
//         {
//           return NotFound();
//         }
//         else
//         {
//           throw;
//         }
//       }

//       return NoContent();
//     }

//     // POST: api/User
//     // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//     // more details see https://aka.ms/RazorPagesCRUD.
//     [HttpPost]
//     public async Task<ActionResult<User>> PostUser(NewUserViewModel vm)
//     {
//       var db = new DatabaseContext();
//       var energyLevel = db.EnergyLevels.FirstOrDefault(energyLevel => energyLevel.Id == vm.EnergyLevelId);
//       var gender = db.Genders.FirstOrDefault(gender => gender.Id == vm.GenderId);
//       if (energyLevel == null)
//       {
//         return NotFound();
//       }
//       else if (gender == null)
//       {
//         return NotFound();
//       }
//       else
//       {
//         var user = new User
//         {
//           Name = vm.Name,
//           Breed = vm.Breed,
//           About = vm.About,
//           Size = vm.Size,
//           EnergyLevelId = vm.EnergyLevelId,
//           GenderId = vm.GenderId,
//           InterestedEnergyLevelId = vm.EnergyLevelId
//         };
//         db.Users.Add(user);
//         db.SaveChanges();
//         var rv = new CreatedUser
//         {
//           Id = user.Id,
//           Name = user.Name,
//           Breed = user.Breed,
//           About = user.About,
//           Size = user.Size,
//           EnergyLevelId = user.EnergyLevelId,
//           GenderId = user.GenderId,
//           InterestedEnergyLevelId = user.EnergyLevelId
//         };
//         return Ok(rv);
//       }

//     }

//     // DELETE: api/User/5
//     [HttpDelete("{id}")]
//     public async Task<ActionResult<User>> DeleteUser(int id)
//     {
//       var user = await _context.Users.FindAsync(id);
//       if (user == null)
//       {
//         return NotFound();
//       }

//       _context.Users.Remove(user);
//       await _context.SaveChangesAsync();

//       return user;
//     }

//     private bool UserExists(int id)
//     {
//       return _context.Users.Any(e => e.Id == id);
//     }
//   }
// }
