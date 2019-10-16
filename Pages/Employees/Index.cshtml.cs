using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SmukToolsApp.Data;
using StudentEmployeeManagementApp.Models;

namespace EmployeeShiftManagement.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public IndexModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee
                .Include(e => e.EmployeeRole).ToListAsync();
        }
    }
}
