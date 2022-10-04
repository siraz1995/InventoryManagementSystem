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
    public class PurchaseOrderController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public PurchaseOrderController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrder>>> GetPurchaseOrders()
        {
            return await _context.PurchaseOrders.ToListAsync();
        }

        // GET: api/PurchaseOrder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrder>> GetPurchaseOrder(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return purchaseOrder;
        }

        // PUT: api/PurchaseOrder/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrder(int id, PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.PurchaseOrderId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderExists(id))
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

        // POST: api/PurchaseOrder
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOrder>> PostPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _context.PurchaseOrders.Add(purchaseOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrder", new { id = purchaseOrder.PurchaseOrderId }, purchaseOrder);
        }

        // DELETE: api/PurchaseOrder/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrder(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            _context.PurchaseOrders.Remove(purchaseOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOrderExists(int id)
        {
            return _context.PurchaseOrders.Any(e => e.PurchaseOrderId == id);
        }
    }
}
