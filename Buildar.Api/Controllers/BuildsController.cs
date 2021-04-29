using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Buildar.DataAccess;
using Buildar.Model;

namespace Buildar.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildsController : ControllerBase
    {
        private readonly BuildarContext _context;

        public BuildsController(BuildarContext context)
        {
            _context = context;
        }

        // GET: api/Builds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Build>>> GetBuilds()
        {
            return await _context.Builds.ToListAsync();
        }

        // GET: api/Builds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Build>> GetBuild(string id)
        {
            var build = await _context.Builds.FindAsync(id);

            if (build == null)
            {
                return NotFound();
            }

            return build;
        }

        // PUT: api/Builds/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuild(string id, Build build)
        {
            if (id != build.BuildId)
            {
                return BadRequest();
            }

            _context.Entry(build).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildExists(id))
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

        // POST: api/Builds
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Build>> PostBuild(Build build)
        {
            _context.Builds.Add(build);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BuildExists(build.BuildId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBuild", new { id = build.BuildId }, build);
        }

        // DELETE: api/Builds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Build>> DeleteBuild(string id)
        {
            var build = await _context.Builds.FindAsync(id);
            if (build == null)
            {
                return NotFound();
            }

            _context.Builds.Remove(build);
            await _context.SaveChangesAsync();

            return build;
        }

        private bool BuildExists(string id)
        {
            return _context.Builds.Any(e => e.BuildId == id);
        }
    }
}
