using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeliveryBookingSystemAPI.Models;

namespace DeliveryBookingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryExecutiveController : ControllerBase
    {
        private readonly DeliveryContext _context;

        public DeliveryExecutiveController(DeliveryContext context)
        {
            _context = context;
        }

        // GET: api/DeliveryExecutive
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeliveryExecutive>>> GetdeliveryExecutives()
        {
            return await _context.deliveryExecutives.ToListAsync();
        }

        // GET: api/DeliveryExecutive/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryExecutive>> GetDeliveryExecutive(int id)
        {
            var deliveryExecutive = await _context.deliveryExecutives.FindAsync(id);

            if (deliveryExecutive == null)
            {
                return NotFound();
            }

            return deliveryExecutive;
        }

        // PUT: api/DeliveryExecutive/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliveryExecutive(int id, DeliveryExecutive deliveryExecutive)
        {
            if (id != deliveryExecutive.executiveID)
            {
                return BadRequest();
            }

            _context.Entry(deliveryExecutive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExecutiveExists(id))
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

        // POST: api/DeliveryExecutive
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DeliveryExecutive>> PostDeliveryExecutive(DeliveryExecutive deliveryExecutive)
        {
            _context.deliveryExecutives.Add(deliveryExecutive);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeliveryExecutive", new { id = deliveryExecutive.executiveID }, deliveryExecutive);
        }

        // DELETE: api/DeliveryExecutive/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeliveryExecutive(int id)
        {
            var deliveryExecutive = await _context.deliveryExecutives.FindAsync(id);
            if (deliveryExecutive == null)
            {
                return NotFound();
            }

            _context.deliveryExecutives.Remove(deliveryExecutive);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeliveryExecutiveExists(int id)
        {
            return _context.deliveryExecutives.Any(e => e.executiveID == id);
        }
    }
}
