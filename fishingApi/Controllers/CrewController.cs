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
    public class CrewController : ControllerBase
    {
        private readonly ICrewRepository repository;

        public CrewController(ICrewRepository repo)
        {
            repository = repo;
        }

        // GET: api/Crew
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CrewMember>>> GetCrewMembers()
        {
            return await repository.CrewMembers.Include(c => c.Boat).ToListAsync();
        }

        // GET: api/Crew/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CrewMember>> GetCrewMember(int id)
        {
            var crewMember = await repository.GetCrewMember(id);

            if (crewMember == null)
            {
                return NotFound();
            }

            return crewMember;
        }

        // PUT: api/Crew/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutCrewMember(int id, CrewMember crewMember)
        // {
        //     if (id != crewMember.CrewMemberId)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(crewMember).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!CrewMemberExists(id))
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

        // POST: api/Crew
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CrewMember>> PostCrewMember(CrewMember crewMember)
        {
            await repository.SaveCrewMember(crewMember);

            return CreatedAtAction("GetCrewMember", new { id = crewMember.CrewMemberId }, crewMember);
        }

        // DELETE: api/Crew/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CrewMember>> DeleteCrewMember(int id)
        {
            var crewMember = await repository.DeleteCrewMember(id);
            if (crewMember == null)
            {
                return NotFound();
            }
            return crewMember;
        }
    }
}
