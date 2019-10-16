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
    public class IndexModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public IndexModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }

        public IList<EmployeeRole> EmployeeRole { get;set; }

        public async Task OnGetAsync()
        {
            EmployeeRole = await _context.EmployeeRole.ToListAsync();
        }
    }
}
