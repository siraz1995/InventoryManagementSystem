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
    public class PurchasePaymentController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public PurchasePaymentController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchasePayment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchasePayment>>> GetPurchasePayments()
        {
            return await _context.PurchasePayments.ToListAsync();
        }

        // GET: api/PurchasePayment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchasePayment>> GetPurchasePayment(int id)
        {
            var purchasePayment = await _context.PurchasePayments.FindAsync(id);

            if (purchasePayment == null)
            {
                return NotFound();
            }

            return purchasePayment;
        }

        // PUT: api/PurchasePayment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchasePayment(int id, PurchasePayment purchasePayment)
        {
            if (id != purchasePayment.PurchasePaymentId)
            {
                return BadRequest();
            }

            _context.Entry(purchasePayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchasePaymentExists(id))
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

        // POST: api/PurchasePayment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchasePayment>> PostPurchasePayment(PurchasePayment purchasePayment)
        {
            _context.PurchasePayments.Add(purchasePayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchasePayment", new { id = purchasePayment.PurchasePaymentId }, purchasePayment);
        }

        // DELETE: api/PurchasePayment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchasePayment(int id)
        {
            var purchasePayment = await _context.PurchasePayments.FindAsync(id);
            if (purchasePayment == null)
            {
                return NotFound();
            }

            _context.PurchasePayments.Remove(purchasePayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchasePaymentExists(int id)
        {
            return _context.PurchasePayments.Any(e => e.PurchasePaymentId == id);
        }
    }
}
