using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoutubeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public YoutubeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Youtube
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Youtube>>> GetYoutube()
        {
            return await _context.Youtube.ToListAsync();
        }

        // GET: api/Youtube/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Youtube>> GetYoutube(int id)
        {
            var youtube = await _context.Youtube.FindAsync(id);

            if (youtube == null)
            {
                return NotFound();
            }

            return youtube;
        }

        // PUT: api/Youtube/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYoutube(int id, Youtube youtube)
        {
            if (id != youtube.Id)
            {
                return BadRequest();
            }

            _context.Entry(youtube).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YoutubeExists(id))
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

        // POST: api/Youtube
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Youtube>> PostYoutube(Youtube youtube)
        {
            _context.Youtube.Add(youtube);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYoutube", new { id = youtube.Id }, youtube);
        }

        // DELETE: api/Youtube/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Youtube>> DeleteYoutube(int id)
        {
            var youtube = await _context.Youtube.FindAsync(id);
            if (youtube == null)
            {
                return NotFound();
            }

            _context.Youtube.Remove(youtube);
            await _context.SaveChangesAsync();

            return youtube;
        }

        private bool YoutubeExists(int id)
        {
            return _context.Youtube.Any(e => e.Id == id);
        }
    }
}
