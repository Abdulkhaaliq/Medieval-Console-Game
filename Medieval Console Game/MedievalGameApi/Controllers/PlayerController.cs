using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedievalGameApi.Models;

namespace MedievalGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly MedievalGameDBContext _context;

        public PlayerController(MedievalGameDBContext context)
        {
            _context = context;
        }

        // GET: api/Player
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player1>>> GetPlayer1s()
        {
            return await _context.Player1s.ToListAsync();
        }

        // GET: api/Player/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player1>> GetPlayer1(int id)
        {
            var player1 = await _context.Player1s.FindAsync(id);

            if (player1 == null)
            {
                return NotFound();
            }

            return player1;
        }

        // PUT: api/Player/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer1(int id, Player1 player1)
        {
            if (id != player1.PlayerId)
            {
                return BadRequest();
            }

            _context.Entry(player1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Player1Exists(id))
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

        // POST: api/Player
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Player1>> PostPlayer1(Player1 player1)
        {
            _context.Player1s.Add(player1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayer1", new { id = player1.PlayerId }, player1);
        }

        // DELETE: api/Player/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer1(int id)
        {
            var player1 = await _context.Player1s.FindAsync(id);
            if (player1 == null)
            {
                return NotFound();
            }

            _context.Player1s.Remove(player1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Player1Exists(int id)
        {
            return _context.Player1s.Any(e => e.PlayerId == id);
        }
    }
}
