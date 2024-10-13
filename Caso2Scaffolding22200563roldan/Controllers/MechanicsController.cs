using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Caso2Scaffolding22200563roldan.Models;

namespace Caso2Scaffolding22200563roldan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicsController : ControllerBase
    {
        private readonly ParcialDbContext _context;

        public MechanicsController(ParcialDbContext context)
        {
            _context = context;
        }

        // GET: api/Mechanics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mechanic>>> GetMechanics()
        {
            return await _context.Mechanics.ToListAsync();
        }

        // GET: api/Mechanics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mechanic>> GetMechanic(int id)
        {
            var mechanic = await _context.Mechanics.FindAsync(id);

            if (mechanic == null)
            {
                return NotFound();
            }

            return mechanic;
        }

        // PUT: api/Mechanics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMechanic(int id, Mechanic mechanic)
        {
            if (id != mechanic.Id)
            {
                return BadRequest();
            }

            _context.Entry(mechanic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MechanicExists(id))
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

        // POST: api/Mechanics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mechanic>> PostMechanic(Mechanic mechanic)
        {
            _context.Mechanics.Add(mechanic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMechanic", new { id = mechanic.Id }, mechanic);
        }

        // DELETE: api/Mechanics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMechanic(int id)
        {
            var mechanic = await _context.Mechanics.FindAsync(id);
            if (mechanic == null)
            {
                return NotFound();
            }

            _context.Mechanics.Remove(mechanic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MechanicExists(int id)
        {
            return _context.Mechanics.Any(e => e.Id == id);
        }
    }
}
