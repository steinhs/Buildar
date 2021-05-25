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
    public class MemoriesController : ControllerBase
    {
        private readonly BuildarContext _context;

        public MemoriesController(BuildarContext context)
        {
            _context = context;
        }

        // GET: api/Memories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Memory>>> GetMemorys()
        {
            return await _context.Memorys.ToListAsync();
        }

        // GET: api/Memories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Memory>> GetMemory(string id)
        {
            var memory = await _context.Memorys.FindAsync(id);

            if (memory == null)
            {
                return NotFound();
            }

            return memory;
        }

        // PUT: api/Memories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMemory(int id, Memory memory)
        {
            if (id != memory.Id)
            {
                return BadRequest();
            }

            _context.Entry(memory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemoryExists(id))
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

        // POST: api/Memories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Memory>> PostMemory(Memory memory)
        {
            _context.Memorys.Add(memory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MemoryExists(memory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMemory", new { id = memory.Id }, memory);
        }

        // DELETE: api/Memories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Memory>> DeleteMemory(string id)
        {
            var memory = await _context.Memorys.FindAsync(id);
            if (memory == null)
            {
                return NotFound();
            }

            _context.Memorys.Remove(memory);
            await _context.SaveChangesAsync();

            return memory;
        }

        private bool MemoryExists(int id)
        {
            return _context.Memorys.Any(e => e.Id.Equals(id));
        }
    }
}
