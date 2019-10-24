using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeShiftManagement.Models;
using SmukToolsApp.Data;
using EmployeeShiftManagement.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace EmployeeShiftManagement.Pages
{
    public class AdminUserShiftsReportModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;
        [BindProperty]

        public int EmployeesID { get; set; }
        [BindProperty]

        public DateTime From { get; set; } = DateTime.Now.AddDays(-7);
        [BindProperty]

        public DateTime To { get; set; } = DateTime.Now.AddDays(1);
        public AdminUserShiftsReportModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        public IList<ShiftApplications> ShiftApplications { get; set; }

        public IActionResult OnGetAsync()
        {
            if (HttpContext.Session.GetInt32("Id") == null)
            {
                return Redirect("/UserAuth/Login");
            }
            ViewData["Employees"] = new SelectList(_context.Employees, "ID", "Username");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ViewData["Employees"] = new SelectList(_context.Employees, "ID", "Username");
            ShiftApplications = await _context.ShiftApplications
            .Include(s => s.Employee)
            .Include(s => s.Shift).Where(x=>x.EmployeeID==this.EmployeesID&&x.Shift.Date.Date>=this.From.Date&& x.Shift.Date.Date <= this.To.Date).ToListAsync();
            return Page();
        }
    }

}
