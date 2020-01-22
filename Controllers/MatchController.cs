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
  [Route("api/[controller]")]
  [ApiController]
  public class MatchController : ControllerBase
  {

    private readonly DatabaseContext _context;

    public MatchController(DatabaseContext context)
    {
      _context = context;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetShyMatches(int id, int EnergyLevelId)
    {
      var db = new DatabaseContext();
      var matchResults = db.Users.Include(i => i.EnergyLevel).Where(w => w.EnergyLevelId == id);
      var rv = new UserItem
      {

      };
      return Ok(rv);
    }

  }
  // var db = new DatabaseContext();
  // var matchResults = db.Users.Include(i => i.EnergyLevel).Include(i => i.InterestedEnergyLevel).Where(w => w.EnergyLevelId == w.InterestedEnergyLevelId);
  // return Ok(await matchResults.ToListAsync());
}




