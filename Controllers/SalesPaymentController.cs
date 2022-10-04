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
    public class SalesPaymentController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public SalesPaymentController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesPayment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesPayment>>> GetSalesPayments()
        {
            return await _context.SalesPayments.ToListAsync();
        }

        // GET: api/SalesPayment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesPayment>> GetSalesPayment(int id)
        {
            var salesPayment = await _context.SalesPayments.FindAsync(id);

            if (salesPayment == null)
            {
                return NotFound();
            }

            return salesPayment;
        }

        // PUT: api/SalesPayment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesPayment(int id, SalesPayment salesPayment)
        {
            if (id != salesPayment.SalesPaymentId)
            {
                return BadRequest();
            }

            _context.Entry(salesPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesPaymentExists(id))
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

        // POST: api/SalesPayment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalesPayment>> PostSalesPayment(SalesPayment salesPayment)
        {
            _context.SalesPayments.Add(salesPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesPayment", new { id = salesPayment.SalesPaymentId }, salesPayment);
        }

        // DELETE: api/SalesPayment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesPayment(int id)
        {
            var salesPayment = await _context.SalesPayments.FindAsync(id);
            if (salesPayment == null)
            {
                return NotFound();
            }

            _context.SalesPayments.Remove(salesPayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesPaymentExists(int id)
        {
            return _context.SalesPayments.Any(e => e.SalesPaymentId == id);
        }
    }
}
