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
    public class PurchaseReturnDetailsController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public PurchaseReturnDetailsController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseReturnDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseReturnDetails>>> GetPurchaseReturnDetails()
        {
            return await _context.PurchaseReturnDetails.ToListAsync();
        }

        // GET: api/PurchaseReturnDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseReturnDetails>> GetPurchaseReturnDetails(int id)
        {
            var purchaseReturnDetails = await _context.PurchaseReturnDetails.FindAsync(id);

            if (purchaseReturnDetails == null)
            {
                return NotFound();
            }

            return purchaseReturnDetails;
        }

        // PUT: api/PurchaseReturnDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseReturnDetails(int id, PurchaseReturnDetails purchaseReturnDetails)
        {
            if (id != purchaseReturnDetails.PurchaseReturnDetailId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseReturnDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseReturnDetailsExists(id))
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

        // POST: api/PurchaseReturnDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseReturnDetails>> PostPurchaseReturnDetails(PurchaseReturnDetails purchaseReturnDetails)
        {
            _context.PurchaseReturnDetails.Add(purchaseReturnDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseReturnDetails", new { id = purchaseReturnDetails.PurchaseReturnDetailId }, purchaseReturnDetails);
        }

        // DELETE: api/PurchaseReturnDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseReturnDetails(int id)
        {
            var purchaseReturnDetails = await _context.PurchaseReturnDetails.FindAsync(id);
            if (purchaseReturnDetails == null)
            {
                return NotFound();
            }

            _context.PurchaseReturnDetails.Remove(purchaseReturnDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseReturnDetailsExists(int id)
        {
            return _context.PurchaseReturnDetails.Any(e => e.PurchaseReturnDetailId == id);
        }
    }
}
