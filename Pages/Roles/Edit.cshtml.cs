using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.Roles
{
    public class EditModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public EditModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public EmployeeRole EmployeeRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeRole = await _context.EmployeeRole.FirstOrDefaultAsync(m => m.ID == id);

            if (EmployeeRole == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmployeeRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeRoleExists(EmployeeRole.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployeeRoleExists(int id)
        {
            return _context.EmployeeRole.Any(e => e.ID == id);
        }
    }
}
