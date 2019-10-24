using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsController : ControllerBase
    {
        private readonly Context _context;

        public ShiftsController(Context context)
        {
            _context = context;
        }

        // GET: api/Shifts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shift>>> GetShifts()
        {
            return await _context.Shifts.ToListAsync();
        }

        // GET: api/Shifts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Shift>>> GetShift(string id)
        {
            var date = DateTime.Parse(id).AddDays(1);
            CreateShifts(date);
            var shifts = await _context.Shifts.Where(x => x.Date.Date == date.Date).ToListAsync();

            return shifts;
        }
        public void CreateShifts(DateTime date)
        {
            if (!_context.Shifts.Any(x => x.Date.Date == date.Date))
            {
                var StartingTime = date.Date.AddHours(8);
                var shifts = new Shift[]
                {
                    new Shift{  StartingTime=new TimeSpan(8,0,0),EndingTime=new TimeSpan(16,0,0),IsMorningShift=true,Date=date.Date}
                    ,
                   new Shift{  StartingTime=new TimeSpan(16,0,0),EndingTime=new TimeSpan(20,0,0),IsMorningShift=false,Date=date.Date}              
                };
                _context.Shifts.AddRange(shifts);
                _context.SaveChanges();
            }
        }
        // PUT: api/Shifts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShift(int id, Shift shift)
        {
            if (id != shift.ID)
            {
                return BadRequest();
            }

            _context.Entry(shift).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftExists(id))
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

        // POST: api/Shifts
        [HttpPost]
        public async Task<ActionResult<Shift>> PostShift(Shift shift)
        {
            _context.Shifts.Add(shift);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShift", new { id = shift.ID }, shift);
        }

        // DELETE: api/Shifts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Shift>> DeleteShift(int id)
        {
            var shift = await _context.Shifts.FindAsync(id);
            if (shift == null)
            {
                return NotFound();
            }

            _context.Shifts.Remove(shift);
            await _context.SaveChangesAsync();

            return shift;
        }

        private bool ShiftExists(int id)
        {
            return _context.Shifts.Any(e => e.ID == id);
        }
    }
}
