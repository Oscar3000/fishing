using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using fishingApi.Data;
using fishingApi.Models;

namespace fishingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatRepository repository;

        public BoatController(IBoatRepository repo)
        {
            repository = repo;
        }

        // GET: api/Boat
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Boat>>> GetBoats()
        {
            return await repository.Boats.Include(c => c.CrewMembers).ToListAsync();
        }

        // GET: api/Boat/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Boat>> GetBoat(int id)
        {
            var boat = await repository.GetBoat(id);

            if (boat == null)
            {
                return NotFound();
            }

            return boat;
        }

        // PUT: api/Boat/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutBoat(int id, Boat boat)
        // {
        //     if (id != boat.BoatId)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(boat).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!BoatExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // POST: api/Boat
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Boat>> PostBoat(Boat boat)
        {
            await repository.SaveBoat(boat);

            return CreatedAtAction("GetBoat", new { id = boat.BoatId }, boat);
        }

        // DELETE: api/Boat/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Boat>> DeleteBoat(int id)
        {
            var boat = await repository.DeleteBoat(id);
            if (boat == null)
            {
                return NotFound();
            }

            return boat;
        }

    }
}
