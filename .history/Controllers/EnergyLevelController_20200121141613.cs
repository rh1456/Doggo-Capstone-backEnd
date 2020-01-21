using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Doggo_Capstone_backEnd.Models;

namespace Doggo_Capstone_backEnd.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EnergyLevelController : ControllerBase
  {
    private readonly DatabaseContext _context;

    public EnergyLevelController(DatabaseContext context)
    {
      _context = context;
    }

    // GET: api/EnergyLevel
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EnergyLevel>>> GetEnergyLevels()
    {

      return await _context.EnergyLevels.ToListAsync();
    }

    // GET: api/EnergyLevel/5
    [HttpGet("{id}")]
    public async Task<ActionResult<EnergyLevel>> GetEnergyLevel(int id)
    {
      var energyLevel = await _context.EnergyLevels.FindAsync(id);

      if (energyLevel == null)
      {
        return NotFound();
      }

      return energyLevel;
    }

    // PUT: api/EnergyLevel/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    // more details see https://aka.ms/RazorPagesCRUD.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutEnergyLevel(int id, EnergyLevel energyLevel)
    {
      if (id != energyLevel.Id)
      {
        return BadRequest();
      }

      _context.Entry(energyLevel).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!EnergyLevelExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/EnergyLevel
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    // more details see https://aka.ms/RazorPagesCRUD.
    [HttpPost]
    public async Task<ActionResult<EnergyLevel>> PostEnergyLevel(EnergyLevel energyLevel)
    {
      _context.EnergyLevels.Add(energyLevel);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetEnergyLevel", new { id = energyLevel.Id }, energyLevel);
    }

    // DELETE: api/EnergyLevel/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<EnergyLevel>> DeleteEnergyLevel(int id)
    {
      var energyLevel = await _context.EnergyLevels.FindAsync(id);
      if (energyLevel == null)
      {
        return NotFound();
      }

      _context.EnergyLevels.Remove(energyLevel);
      await _context.SaveChangesAsync();

      return energyLevel;
    }

    private bool EnergyLevelExists(int id)
    {
      return _context.EnergyLevels.Any(e => e.Id == id);
    }
  }
}