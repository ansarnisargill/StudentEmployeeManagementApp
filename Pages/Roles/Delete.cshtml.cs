using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.Roles
{
    public class DeleteModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public DeleteModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public EmployeeRole EmployeeRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (HttpContext.Session.GetInt32("Id") == null)
            {
                return Redirect("/UserAuth/Login");
            }
            if (id == null)
            {
                return NotFound();
            }

            EmployeeRole = await _context.EmployeeRoles.FirstOrDefaultAsync(m => m.ID == id);

            if (EmployeeRole == null)
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

            EmployeeRole = await _context.EmployeeRoles.FindAsync(id);

            if (EmployeeRole != null)
            {
                _context.EmployeeRoles.Remove(EmployeeRole);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
