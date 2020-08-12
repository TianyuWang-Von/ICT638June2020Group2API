using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ICT638June2020Group2API.Models;

namespace ICT638June2020Group2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomInfoesController : ControllerBase
    {
        private readonly RoomContext _context;

        public RoomInfoesController(RoomContext context)
        {
            _context = context;
        }

        // GET: api/RoomInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomInfo>>> GetroomInfo()
        {
            return await _context.roomInfo.ToListAsync();
        }

        // GET: api/RoomInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomInfo>> GetRoomInfo(int id)
        {
            var roomInfo = await _context.roomInfo.FindAsync(id);

            if (roomInfo == null)
            {
                return NotFound();
            }

            return roomInfo;
        }

        // PUT: api/RoomInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomInfo(int id, RoomInfo roomInfo)
        {
            if (id != roomInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(roomInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomInfoExists(id))
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

        // POST: api/RoomInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RoomInfo>> PostRoomInfo(RoomInfo roomInfo)
        {
            _context.roomInfo.Add(roomInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoomInfo", new { id = roomInfo.Id }, roomInfo);
        }

        // DELETE: api/RoomInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RoomInfo>> DeleteRoomInfo(int id)
        {
            var roomInfo = await _context.roomInfo.FindAsync(id);
            if (roomInfo == null)
            {
                return NotFound();
            }

            _context.roomInfo.Remove(roomInfo);
            await _context.SaveChangesAsync();

            return roomInfo;
        }

        private bool RoomInfoExists(int id)
        {
            return _context.roomInfo.Any(e => e.Id == id);
        }
    }
}
