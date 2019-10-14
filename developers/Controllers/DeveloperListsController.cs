using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using developers.Models;

namespace developers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperListsController : ControllerBase
    {
        
        private readonly DeveloperListContext _context;

        public DeveloperListsController(DeveloperListContext context)
        {
            _context = context;
        }

        // GET: api/DeveloperLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeveloperList>>> GetDeveloperLists()
        {
            return await _context.DeveloperLists.ToListAsync();
        }

        // GET: api/DeveloperLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperList>> GetDeveloperList(int id)
        {
            var developerList = await _context.DeveloperLists.FindAsync(id);

            if (developerList == null)
            {
                return NotFound();
            }

            return developerList;
        }

        // PUT: api/DeveloperLists/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeveloperList(int id, DeveloperList developerList)
        {
            if (id != developerList.Id)
            {
                return BadRequest();
            }

            _context.Entry(developerList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeveloperListExists(id))
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

        // POST: api/DeveloperLists
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DeveloperList>> PostDeveloperList(DeveloperList developerList)
        {
            _context.DeveloperLists.Add(developerList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeveloperList", new { id = developerList.Id }, developerList);
        }

        // DELETE: api/DeveloperLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeveloperList>> DeleteDeveloperList(int id)
        {
            var developerList = await _context.DeveloperLists.FindAsync(id);
            if (developerList == null)
            {
                return NotFound();
            }

            _context.DeveloperLists.Remove(developerList);
            await _context.SaveChangesAsync();

            return developerList;
        }

        private bool DeveloperListExists(int id)
        {
            return _context.DeveloperLists.Any(e => e.Id == id);
        }
    }
}
