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
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages
{
    public class EmployeeWorkReportModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;
        [BindProperty]

        public int EmployeesID { get; set; }
        [BindProperty]

        public DateTime From { get; set; } = DateTime.Now.AddDays(-7);
        [BindProperty]

        public DateTime To { get; set; } = DateTime.Now.AddDays(1);
        public EmployeeWorkReportModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        public List<ShiftDTO> ShiftApplications { get; set; }

        public IActionResult OnGetAsync()
        {
            if (HttpContext.Session.GetInt32("Id") == null)
            {
                return Redirect("/UserAuth/Login");
            }
            var listOfEmployees = _context.Employees.ToList();
            listOfEmployees.Add(new Employee() { ID = 0, Username = "All" });
            ViewData["Employees"] = new SelectList(listOfEmployees, "ID", "Username");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var listOfEmployees = _context.Employees.ToList();
            listOfEmployees.Add(new Employee() { ID = 0, Username = "All" });
            ViewData["Employees"] = new SelectList(listOfEmployees, "ID", "Username");
            ShiftApplications = await _context.Shifts
            .Where(x => x.Date.Date >= this.From.Date && x.Date.Date <= this.To.Date)
            .Select(x => new ShiftDTO { Date = x.Date, StartTime = x.StartingTime.ToString(), EndTime = x.EndingTime.ToString(), ID = x.ID, IsMorningShift = x.IsMorningShift })
            .ToListAsync();
            this.ShiftApplications.ForEach(x =>
            {
                x.Employees = _context.ShiftApplications.Where(y => y.ShiftID == x.ID).Select(y => new EmployeeDTO { ID = y.Employee.ID, Name = y.Employee.Username }).ToList();
            });
            this.ShiftApplications = this.ShiftApplications.Where(x => x.Employees.Count > 0).ToList();
            if (this.EmployeesID != 0)
            {
                this.ShiftApplications = this.ShiftApplications.Where(x => x.Employees.Any(y => y.ID == this.EmployeesID)).ToList();
            }
            this.ShiftApplications = this.ShiftApplications.OrderByDescending(x => x.Date).ToList();
            return Page();
        }
    }

}
