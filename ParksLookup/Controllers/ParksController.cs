using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkLookup.Models;

namespace ParkLookup.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase {
    private readonly ParkLookupContext _context;

    public ParksController(ParkLookupContext context) {
      _context = context;
    }

    // GET: api/Parkså
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, int established, string province, int coordinates) {
      var query = _context.Parks.AsQueryable();

      if (name != null) {
        query = query.Where(entry => entry.Name == name);
      }
      if (established != 0) {
        query = query.Where(entry => entry.Established == established);
      }
      if (province != null) {
        query = query.Where(entry => entry.Province == province);
      }
      if (coordinates != 0) {
        query = query.Where(entry => entry.Coordinates == coordinates);
      }

      return await query.ToListAsync();
    }

    // GET: api/Parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id) {
      var Park = await _context.Parks.FindAsync(id);

      if (Park == null) {
        return NotFound();
      }

      return Park;
    }

    // PUT: api/Parks/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPark(int id, Park park) {
      if (id != park.ParkId) {
        return BadRequest();
      }

      _context.Entry(park).State = EntityState.Modified;

      try {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException) {
        if (!ParkExists(id)) {
          return NotFound();
        }
        else {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/Parks
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Park>> PostPark(Park Park) {
      _context.Parks.Add(Park);
      await _context.SaveChangesAsync();

      return CreatedAtAction("{PostPark", new { id = Park.ParkId }, Park);
    }                         // location      // new id                //actual instance of the Park 

    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id) {
      var Park = await _context.Parks.FindAsync(id);
      if (Park == null) {
        return NotFound();
      }

      _context.Parks.Remove(Park);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id) {
      return _context.Parks.Any(e => e.ParkId == id);
    }
  }
}
