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
    public class PurchaseReturnController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public PurchaseReturnController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseReturn
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseReturn>>> GetPurchaseReturns()
        {
            return await _context.PurchaseReturns.ToListAsync();
        }

        // GET: api/PurchaseReturn/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseReturn>> GetPurchaseReturn(int id)
        {
            var purchaseReturn = await _context.PurchaseReturns.FindAsync(id);

            if (purchaseReturn == null)
            {
                return NotFound();
            }

            return purchaseReturn;
        }

        // PUT: api/PurchaseReturn/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseReturn(int id, PurchaseReturn purchaseReturn)
        {
            if (id != purchaseReturn.PurchaseReturnId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseReturn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseReturnExists(id))
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

        // POST: api/PurchaseReturn
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseReturn>> PostPurchaseReturn(PurchaseReturn purchaseReturn)
        {
            _context.PurchaseReturns.Add(purchaseReturn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseReturn", new { id = purchaseReturn.PurchaseReturnId }, purchaseReturn);
        }

        // DELETE: api/PurchaseReturn/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseReturn(int id)
        {
            var purchaseReturn = await _context.PurchaseReturns.FindAsync(id);
            if (purchaseReturn == null)
            {
                return NotFound();
            }

            _context.PurchaseReturns.Remove(purchaseReturn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseReturnExists(int id)
        {
            return _context.PurchaseReturns.Any(e => e.PurchaseReturnId == id);
        }
    }
}
