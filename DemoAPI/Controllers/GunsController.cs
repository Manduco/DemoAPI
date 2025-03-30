using DemoAPI.Data;
using DemoAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GunsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GunsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/guns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gun>>> GetGuns()
        {
            return await _context.Guns.ToListAsync();
        }

        // GET: api/guns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gun>> GetGun(int id)
        {
            var gun = await _context.Guns.FindAsync(id);
            if (gun == null)
                return NotFound();
            return gun;
        }

        // POST: api/guns
        [HttpPost]
        public async Task<ActionResult<Gun>> PostGun(Gun gun)
        {
            _context.Guns.Add(gun);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetGun), new { id = gun.Id }, gun);
        }

        // PUT: api/guns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGun(int id, Gun gun)
        {
            if (id != gun.Id) return BadRequest();

            _context.Entry(gun).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/guns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGun(int id)
        {
            var gun = await _context.Guns.FindAsync(id);
            if (gun == null) return NotFound();

            _context.Guns.Remove(gun);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
