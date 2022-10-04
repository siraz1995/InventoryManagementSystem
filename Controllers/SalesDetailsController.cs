using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.DB;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesDetailsController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public SalesDetailsController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesDetails>>> GetSalesDetails()
        {
            return await _context.SalesDetails.ToListAsync();
        }

        // GET: api/SalesDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesDetails>> GetSalesDetails(int id)
        {
            var salesDetails = await _context.SalesDetails.FindAsync(id);

            if (salesDetails == null)
            {
                return NotFound();
            }

            return salesDetails;
        }

        // PUT: api/SalesDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesDetails(int id, SalesDetails salesDetails)
        {
            if (id != salesDetails.SalesDetailId)
            {
                return BadRequest();
            }

            _context.Entry(salesDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesDetailsExists(id))
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

        // POST: api/SalesDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalesDetails>> PostSalesDetails(SalesDetails salesDetails)
        {
            _context.SalesDetails.Add(salesDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesDetails", new { id = salesDetails.SalesDetailId }, salesDetails);
        }

        // DELETE: api/SalesDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesDetails(int id)
        {
            var salesDetails = await _context.SalesDetails.FindAsync(id);
            if (salesDetails == null)
            {
                return NotFound();
            }

            _context.SalesDetails.Remove(salesDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesDetailsExists(int id)
        {
            return _context.SalesDetails.Any(e => e.SalesDetailId == id);
        }
    }
}
