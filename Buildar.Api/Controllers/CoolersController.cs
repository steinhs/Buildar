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
    public class CoolersController : ControllerBase
    {
        private readonly BuildarContext _context;

        public CoolersController(BuildarContext context)
        {
            _context = context;
        }

        // GET: api/Coolers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cooler>>> GetCoolers()
        {
            return await _context.Coolers.ToListAsync();
        }

        // GET: api/Coolers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cooler>> GetCooler(string id)
        {
            var cooler = await _context.Coolers.FindAsync(id);

            if (cooler == null)
            {
                return NotFound();
            }

            return cooler;
        }

        // PUT: api/Coolers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCooler(int id, Cooler cooler)
        {
            if (id != cooler.Id)
            {
                return BadRequest();
            }

            _context.Entry(cooler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoolerExists(id))
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

        // POST: api/Coolers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cooler>> PostCooler(Cooler cooler)
        {
            _context.Coolers.Add(cooler);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CoolerExists(cooler.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCooler", new { id = cooler.Id }, cooler);
        }

        // DELETE: api/Coolers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cooler>> DeleteCooler(string id)
        {
            var cooler = await _context.Coolers.FindAsync(id);
            if (cooler == null)
            {
                return NotFound();
            }

            _context.Coolers.Remove(cooler);
            await _context.SaveChangesAsync();

            return cooler;
        }

        private bool CoolerExists(int id)
        {
            return _context.Coolers.Any(e => e.Id == id);
        }
    }
}
