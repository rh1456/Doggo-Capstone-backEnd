// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Doggo_Capstone_backEnd.Models;

// namespace Doggo_Capstone_backEnd.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class InterestedEnergyLevel : ControllerBase
//     {
//         private readonly DatabaseContext _context;

//         public InterestedEnergyLevel(DatabaseContext context)
//         {
//             _context = context;
//         }

//         // GET: api/InterestedEnergyLevel
//         [HttpGet]
//         public async Task<ActionResult<IEnumerable<InterestedEnergyLevel>>> GetInterestedEnergyLevel()
//         {
//             return await _context.InterestedEnergyLevel.ToListAsync();
//         }

//         // GET: api/InterestedEnergyLevel/5
//         [HttpGet("{id}")]
//         public async Task<ActionResult<InterestedEnergyLevel>> GetInterestedEnergyLevel(int id)
//         {
//             var interestedEnergyLevel = await _context.InterestedEnergyLevel.FindAsync(id);

//             if (interestedEnergyLevel == null)
//             {
//                 return NotFound();
//             }

//             return interestedEnergyLevel;
//         }

//         // PUT: api/InterestedEnergyLevel/5
//         // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//         // more details see https://aka.ms/RazorPagesCRUD.
//         [HttpPut("{id}")]
//         public async Task<IActionResult> PutInterestedEnergyLevel(int id, InterestedEnergyLevel interestedEnergyLevel)
//         {
//             if (id != interestedEnergyLevel.Id)
//             {
//                 return BadRequest();
//             }

//             _context.Entry(interestedEnergyLevel).State = EntityState.Modified;

//             try
//             {
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!InterestedEnergyLevelExists(id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         // POST: api/InterestedEnergyLevel
//         // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//         // more details see https://aka.ms/RazorPagesCRUD.
//         [HttpPost]
//         public async Task<ActionResult<InterestedEnergyLevel>> PostInterestedEnergyLevel(InterestedEnergyLevel interestedEnergyLevel)
//         {
//             _context.InterestedEnergyLevel.Add(interestedEnergyLevel);
//             await _context.SaveChangesAsync();

//             return CreatedAtAction("GetInterestedEnergyLevel", new { id = interestedEnergyLevel.Id }, interestedEnergyLevel);
//         }

//         // DELETE: api/InterestedEnergyLevel/5
//         [HttpDelete("{id}")]
//         public async Task<ActionResult<InterestedEnergyLevel>> DeleteInterestedEnergyLevel(int id)
//         {
//             var interestedEnergyLevel = await _context.InterestedEnergyLevel.FindAsync(id);
//             if (interestedEnergyLevel == null)
//             {
//                 return NotFound();
//             }

//             _context.InterestedEnergyLevel.Remove(interestedEnergyLevel);
//             await _context.SaveChangesAsync();

//             return interestedEnergyLevel;
//         }

//         private bool InterestedEnergyLevelExists(int id)
//         {
//             return _context.InterestedEnergyLevel.Any(e => e.Id == id);
//         }
//     }
// }
