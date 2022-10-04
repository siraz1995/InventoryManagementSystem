﻿using System;
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
    public class CompanyInfoController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public CompanyInfoController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/CompanyInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyInfo>>> GetCompanyInfos()
        {
            return await _context.CompanyInfos.ToListAsync();
        }

        // GET: api/CompanyInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyInfo>> GetCompanyInfo(int id)
        {
            var companyInfo = await _context.CompanyInfos.FindAsync(id);

            if (companyInfo == null)
            {
                return NotFound();
            }

            return companyInfo;
        }

        // PUT: api/CompanyInfo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyInfo(int id, CompanyInfo companyInfo)
        {
            if (id != companyInfo.CompanyInfoId)
            {
                return BadRequest();
            }

            _context.Entry(companyInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyInfoExists(id))
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

        // POST: api/CompanyInfo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompanyInfo>> PostCompanyInfo(CompanyInfo companyInfo)
        {
            _context.CompanyInfos.Add(companyInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompanyInfo", new { id = companyInfo.CompanyInfoId }, companyInfo);
        }

        // DELETE: api/CompanyInfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyInfo(int id)
        {
            var companyInfo = await _context.CompanyInfos.FindAsync(id);
            if (companyInfo == null)
            {
                return NotFound();
            }

            _context.CompanyInfos.Remove(companyInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyInfoExists(int id)
        {
            return _context.CompanyInfos.Any(e => e.CompanyInfoId == id);
        }
    }
}
