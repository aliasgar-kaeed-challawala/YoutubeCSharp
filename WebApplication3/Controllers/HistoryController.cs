using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/History
        [HttpGet]
        public async Task<ActionResult<IEnumerable<History>>> GetHistory(User User)
        {
            // get history with video and user where user id is the same as the user id in the history
            var history = await _context.History.Include(h => h.Video).Include(h => h.User).Where(h => h.User.UserId == User.UserId).ToListAsync();
            return history;
        }

        // GET: api/History/5
        [HttpGet("{id}")]
        public async Task<ActionResult<History>> GetHistory(string id)
        {
            var history = await _context.History.FindAsync(id);

            if (history == null)
            {
                return NotFound();
            }

            return history;
        }

        // PUT: api/History/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistory(string id, History history)
        {
            if (id != history.HistoryId)
            {
                return BadRequest();
            }

            _context.Entry(history).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoryExists(id))
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

        // POST: api/History
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<History>> PostHistory(History history)
        {
            _context.History.Add(history);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HistoryExists(history.HistoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHistory", new { id = history.HistoryId }, history);
        }

        // DELETE: api/History/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<History>> DeleteHistory(string id)
        {
            var history = await _context.History.FindAsync(id);
            if (history == null)
            {
                return NotFound();
            }

            _context.History.Remove(history);
            await _context.SaveChangesAsync();

            return history;
        }

        private bool HistoryExists(string id)
        {
            return _context.History.Any(e => e.HistoryId == id);
        }
    }
}
