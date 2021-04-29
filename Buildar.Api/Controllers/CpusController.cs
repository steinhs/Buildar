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
    public class CpusController : ControllerBase
    {
        private readonly BuildarContext _context;

        public CpusController(BuildarContext context)
        {
            _context = context;
        }

        // GET: api/Cpus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cpu>>> GetCpus()
        {
            return await _context.Cpus.ToListAsync();
        }

        // GET: api/Cpus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cpu>> GetCpu(string id)
        {
            var cpu = await _context.Cpus.FindAsync(id);

            if (cpu == null)
            {
                return NotFound();
            }

            return cpu;
        }

        // PUT: api/Cpus/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCpu(string id, Cpu cpu)
        {
            if (id != cpu.CpuId)
            {
                return BadRequest();
            }

            _context.Entry(cpu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CpuExists(id))
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

        // POST: api/Cpus
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cpu>> PostCpu(Cpu cpu)
        {
            _context.Cpus.Add(cpu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CpuExists(cpu.CpuId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCpu", new { id = cpu.CpuId }, cpu);
        }

        // DELETE: api/Cpus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cpu>> DeleteCpu(string id)
        {
            var cpu = await _context.Cpus.FindAsync(id);
            if (cpu == null)
            {
                return NotFound();
            }

            _context.Cpus.Remove(cpu);
            await _context.SaveChangesAsync();

            return cpu;
        }

        private bool CpuExists(string id)
        {
            return _context.Cpus.Any(e => e.CpuId == id);
        }
    }
}
