using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.Shifts
{
    public class DeleteModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public DeleteModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Shift Shift { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shift = await _context.Shifts.FirstOrDefaultAsync(m => m.ID == id);

            if (Shift == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shift = await _context.Shifts.FindAsync(id);

            if (Shift != null)
            {
                _context.Shifts.Remove(Shift);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
