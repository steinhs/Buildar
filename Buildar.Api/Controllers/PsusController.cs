using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Buildar.DataAccess;
using Buildar.Model.Parts;

namespace Buildar.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PsusController : ControllerBase
    {
        private readonly BuildarContext _context;

        public PsusController(BuildarContext context)
        {
            _context = context;
        }

        // GET: api/Psus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Psu>>> GetPsus()
        {
            return await _context.Psus.ToListAsync();
        }

        // GET: api/Psus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Psu>> GetPsu(string id)
        {
            var psu = await _context.Psus.FindAsync(id);

            if (psu == null)
            {
                return NotFound();
            }

            return psu;
        }

        // PUT: api/Psus/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPsu(int id, Psu psu)
        {
            if (!id.Equals(psu.Id))
            {
                return BadRequest();
            }

            _context.Entry(psu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PsuExists(id))
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

        // POST: api/Psus
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Psu>> PostPsu(Psu psu)
        {
            _context.Psus.Add(psu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PsuExists(psu.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPsu", new { id = psu.Id }, psu);
        }

        // DELETE: api/Psus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Psu>> DeletePsu(string id)
        {
            var psu = await _context.Psus.FindAsync(id);
            if (psu == null)
            {
                return NotFound();
            }

            _context.Psus.Remove(psu);
            await _context.SaveChangesAsync();

            return psu;
        }

        private bool PsuExists(int id)
        {
            return _context.Psus.Any(e => e.Id.Equals(id));
        }
    }
}
