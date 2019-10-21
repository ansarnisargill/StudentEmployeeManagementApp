using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.EmployeesManagement
{
    public class LoginModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public LoginModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; } = new Employee();

        public async Task<IActionResult> OnGetAsync()
        {
           ViewData["EmployeeRoleId"] = new SelectList(await _context.EmployeeRoles.ToListAsync(), "ID", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            var user =await _context.Employees.Where(x => x.Username == this.Employee.Username && x.Password == this.Employee.Password).FirstOrDefaultAsync();
            if (user != null)
            {
                HttpContext.Session.SetInt32("Id", user.ID);
                return RedirectToPage("/Index");
            }
            else
            {
                ViewData["EmployeeRoleId"] = new SelectList(_context.EmployeeRoles, "ID", "Name");
                return Page();
            }

        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.ID == id);
        }
    }
}