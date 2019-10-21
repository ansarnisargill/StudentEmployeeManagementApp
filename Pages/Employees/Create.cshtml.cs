using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.Employees
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
        ViewData["EmployeeRoleId"] = new SelectList(_context.EmployeeRoles, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}