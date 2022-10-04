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
    public class PurchaseOrderDetailsController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public PurchaseOrderDetailsController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrderDetails>>> GetPurchaseOrderDetails()
        {
            return await _context.PurchaseOrderDetails.ToListAsync();
        }

        // GET: api/PurchaseOrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderDetails>> GetPurchaseOrderDetails(int id)
        {
            var purchaseOrderDetails = await _context.PurchaseOrderDetails.FindAsync(id);

            if (purchaseOrderDetails == null)
            {
                return NotFound();
            }

            return purchaseOrderDetails;
        }

        // PUT: api/PurchaseOrderDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderDetails(int id, PurchaseOrderDetails purchaseOrderDetails)
        {
            if (id != purchaseOrderDetails.PurchaseOrderDetailsId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrderDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderDetailsExists(id))
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

        // POST: api/PurchaseOrderDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOrderDetails>> PostPurchaseOrderDetails(PurchaseOrderDetails purchaseOrderDetails)
        {
            _context.PurchaseOrderDetails.Add(purchaseOrderDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrderDetails", new { id = purchaseOrderDetails.PurchaseOrderDetailsId }, purchaseOrderDetails);
        }

        // DELETE: api/PurchaseOrderDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrderDetails(int id)
        {
            var purchaseOrderDetails = await _context.PurchaseOrderDetails.FindAsync(id);
            if (purchaseOrderDetails == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderDetails.Remove(purchaseOrderDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOrderDetailsExists(int id)
        {
            return _context.PurchaseOrderDetails.Any(e => e.PurchaseOrderDetailsId == id);
        }
    }
}
