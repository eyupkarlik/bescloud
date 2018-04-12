using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using besCenter.Models;

namespace besCenter.Controllers
{
    [Produces("application/json")]
    [Route("api/BESOrtaks")]
    public class BESOrtaksController : Controller
    {
        private readonly BESContext _context;

        public BESOrtaksController(BESContext context)
        {
            _context = context;
        }

        // GET: api/BESOrtaks
        [HttpGet]
        public IEnumerable<BESOrtak> GetBESOrtaks()
        {
            return _context.BESOrtaks;
        }

        [HttpGet("{tc}")]
        public async Task<IActionResult> GetBesOrtakTC([FromRoute] int TC)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bESOrtak = await _context.BESOrtaks.FirstAsync<BESOrtak>(o => o.TC == TC);
            if (bESOrtak == null)
            {
                return NotFound();
            }
            return Ok(bESOrtak);
        }

        // GET: api/BESOrtaks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBESOrtak([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bESOrtak = await _context.BESOrtaks.SingleOrDefaultAsync(m => m.ID == id);

            if (bESOrtak == null)
            {
                return NotFound();
            }

            return Ok(bESOrtak);
        }

        // PUT: api/BESOrtaks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBESOrtak([FromRoute] int id, [FromBody] BESOrtak bESOrtak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bESOrtak.ID)
            {
                return BadRequest();
            }

            _context.Entry(bESOrtak).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BESOrtakExists(id))
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

        // POST: api/BESOrtaks
        [HttpPost]
        public async Task<IActionResult> PostBESOrtak([FromBody] BESOrtak bESOrtak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BESOrtaks.Add(bESOrtak);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBESOrtak", new { id = bESOrtak.ID }, bESOrtak);
        }

        // DELETE: api/BESOrtaks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBESOrtak([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bESOrtak = await _context.BESOrtaks.SingleOrDefaultAsync(m => m.ID == id);
            if (bESOrtak == null)
            {
                return NotFound();
            }

            _context.BESOrtaks.Remove(bESOrtak);
            await _context.SaveChangesAsync();

            return Ok(bESOrtak);
        }

        private bool BESOrtakExists(int id)
        {
            return _context.BESOrtaks.Any(e => e.ID == id);
        }
    }
}