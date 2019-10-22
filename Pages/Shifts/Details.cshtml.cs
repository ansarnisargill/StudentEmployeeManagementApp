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

namespace EmployeeShiftManagement.Pages.Shifts
{
    public class DetailsModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public DetailsModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        public Shift Shift { get; set; }

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

            Shift = await _context.Shifts.FirstOrDefaultAsync(m => m.ID == id);

            if (Shift == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
