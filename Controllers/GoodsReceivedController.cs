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
    public class GoodsReceivedController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public GoodsReceivedController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/GoodsReceived
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoodsReceived>>> GetGoodsReceiveds()
        {
            return await _context.GoodsReceiveds.ToListAsync();
        }

        // GET: api/GoodsReceived/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GoodsReceived>> GetGoodsReceived(int id)
        {
            var goodsReceived = await _context.GoodsReceiveds.FindAsync(id);

            if (goodsReceived == null)
            {
                return NotFound();
            }

            return goodsReceived;
        }

        // PUT: api/GoodsReceived/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoodsReceived(int id, GoodsReceived goodsReceived)
        {
            if (id != goodsReceived.GoodReceivedId)
            {
                return BadRequest();
            }

            _context.Entry(goodsReceived).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoodsReceivedExists(id))
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

        // POST: api/GoodsReceived
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GoodsReceived>> PostGoodsReceived(GoodsReceived goodsReceived)
        {
            _context.GoodsReceiveds.Add(goodsReceived);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGoodsReceived", new { id = goodsReceived.GoodReceivedId }, goodsReceived);
        }

        // DELETE: api/GoodsReceived/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoodsReceived(int id)
        {
            var goodsReceived = await _context.GoodsReceiveds.FindAsync(id);
            if (goodsReceived == null)
            {
                return NotFound();
            }

            _context.GoodsReceiveds.Remove(goodsReceived);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GoodsReceivedExists(int id)
        {
            return _context.GoodsReceiveds.Any(e => e.GoodReceivedId == id);
        }
    }
}
