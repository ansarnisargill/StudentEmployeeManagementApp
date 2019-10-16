using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.Roles
{
    public class DetailsModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public DetailsModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

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
    }
}
