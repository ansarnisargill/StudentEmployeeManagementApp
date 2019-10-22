using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.Shifts
{
    public class CreateModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public CreateModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetInt32("Id") == null)
            {
                return Redirect("/UserAuth/Login");
            }
            return Page();
        }

        [BindProperty]
        public Shift Shift { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shifts.Add(Shift);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}