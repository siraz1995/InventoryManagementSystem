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
    public class ItemStockController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public ItemStockController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemStock
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemStock>>> GetItemStocks()
        {
            return await _context.ItemStocks.ToListAsync();
        }

        // GET: api/ItemStock/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemStock>> GetItemStock(int id)
        {
            var itemStock = await _context.ItemStocks.FindAsync(id);

            if (itemStock == null)
            {
                return NotFound();
            }

            return itemStock;
        }

        // PUT: api/ItemStock/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemStock(int id, ItemStock itemStock)
        {
            if (id != itemStock.StockId)
            {
                return BadRequest();
            }

            _context.Entry(itemStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemStockExists(id))
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

        // POST: api/ItemStock
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemStock>> PostItemStock(ItemStock itemStock)
        {
            _context.ItemStocks.Add(itemStock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemStock", new { id = itemStock.StockId }, itemStock);
        }

        // DELETE: api/ItemStock/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemStock(int id)
        {
            var itemStock = await _context.ItemStocks.FindAsync(id);
            if (itemStock == null)
            {
                return NotFound();
            }

            _context.ItemStocks.Remove(itemStock);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemStockExists(int id)
        {
            return _context.ItemStocks.Any(e => e.StockId == id);
        }
    }
}
