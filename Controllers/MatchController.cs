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

    [HttpGet("{energyLevelId}")]
    public async Task<ActionResult<User>> GetEnergyMatches(int energyLevelId)
    {
      var db = new DatabaseContext();
      var matchResults = db.Users.Where(w => w.EnergyLevelId == energyLevelId);
      return Ok(matchResults);
    }

  }
  // var db = new DatabaseContext();
  // var matchResults = db.Users.Include(i => i.EnergyLevel).Include(i => i.InterestedEnergyLevel).Where(w => w.EnergyLevelId == w.InterestedEnergyLevelId);
  // return Ok(await matchResults.ToListAsync());
}




