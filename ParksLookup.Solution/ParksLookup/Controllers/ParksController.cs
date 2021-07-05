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

  //   // GET: api/Parkså
  //   [HttpGet]
  //   public async Task<ActionResult<IEnumerable<Animal>>> Get(string species, int id, string name, string gender, int age) {
  //     var query = _context.Parks.AsQueryable();

  //     if (species != null) {
  //       query = query.Where(entry => entry.Species == species);
  //     }
  //     if (id != 0) {
  //       query = query.Where(entry => entry.AnimalId == id);
  //     }
  //     if (name != null) {
  //       query = query.Where(entry => entry.Name == name);
  //     }
  //     if (gender != null) {
  //       query = query.Where(entry => entry.Gender == gender);
  //     }
  //     if (age != 0) {
  //       query = query.Where(entry => entry.Gender == gender);
  //     }

  //     return await query.ToListAsync();
  //   }

  //   // GET: api/Parks/5
  //   [HttpGet("{id}")]
  //   public async Task<ActionResult<Animal>> GetAnimal(int id) {
  //     var animal = await _context.Parks.FindAsync(id);

  //     if (animal == null) {
  //       return NotFound();
  //     }

  //     return animal;
  //   }

  //   // PUT: api/Parks/5
  //   // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
  //   [HttpPut("{id}")]
  //   public async Task<IActionResult> PutAnimal(int id, Animal animal) {
  //     if (id != animal.AnimalId) {
  //       return BadRequest();
  //     }

  //     _context.Entry(animal).State = EntityState.Modified;

  //     try {
  //       await _context.SaveChangesAsync();
  //     }
  //     catch (DbUpdateConcurrencyException) {
  //       if (!AnimalExists(id)) {
  //         return NotFound();
  //       }
  //       else {
  //         throw;
  //       }
  //     }

  //     return NoContent();
  //   }

  //   // POST: api/Parks
  //   // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
  //   [HttpPost]
  //   public async Task<ActionResult<Animal>> PostAnimal(Animal animal) {
  //     _context.Parks.Add(animal);
  //     await _context.SaveChangesAsync();

  //     return CreatedAtAction("GetAnimal", new { id = animal.AnimalId }, animal);
  //   }                         // location      // new id                //actual instance of the animal 

  //   // DELETE: api/Parks/5
  //   [HttpDelete("{id}")]
  //   public async Task<IActionResult> DeleteAnimal(int id) {
  //     var animal = await _context.Parks.FindAsync(id);
  //     if (animal == null) {
  //       return NotFound();
  //     }

  //     _context.Parks.Remove(animal);
  //     await _context.SaveChangesAsync();

  //     return NoContent();
  //   }

  //   private bool AnimalExists(int id) {
  //     return _context.Parks.Any(e => e.AnimalId == id);
    // }
  }
}

