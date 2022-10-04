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
    public class SalesReturnDetailsController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public SalesReturnDetailsController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesReturnDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesReturnDetails>>> GetSalesReturnDetails()
        {
            return await _context.SalesReturnDetails.ToListAsync();
        }

        // GET: api/SalesReturnDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesReturnDetails>> GetSalesReturnDetails(int id)
        {
            var salesReturnDetails = await _context.SalesReturnDetails.FindAsync(id);

            if (salesReturnDetails == null)
            {
                return NotFound();
            }

            return salesReturnDetails;
        }

        // PUT: api/SalesReturnDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesReturnDetails(int id, SalesReturnDetails salesReturnDetails)
        {
            if (id != salesReturnDetails.SalesReturnDetailsId)
            {
                return BadRequest();
            }

            _context.Entry(salesReturnDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesReturnDetailsExists(id))
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

        // POST: api/SalesReturnDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalesReturnDetails>> PostSalesReturnDetails(SalesReturnDetails salesReturnDetails)
        {
            _context.SalesReturnDetails.Add(salesReturnDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesReturnDetails", new { id = salesReturnDetails.SalesReturnDetailsId }, salesReturnDetails);
        }

        // DELETE: api/SalesReturnDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesReturnDetails(int id)
        {
            var salesReturnDetails = await _context.SalesReturnDetails.FindAsync(id);
            if (salesReturnDetails == null)
            {
                return NotFound();
            }

            _context.SalesReturnDetails.Remove(salesReturnDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesReturnDetailsExists(int id)
        {
            return _context.SalesReturnDetails.Any(e => e.SalesReturnDetailsId == id);
        }
    }
}
