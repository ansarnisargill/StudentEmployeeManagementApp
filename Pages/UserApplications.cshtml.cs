using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeShiftManagement.Models;
using SmukToolsApp.Data;
using Microsoft.AspNetCore.Http;

namespace EmployeeShiftManagement.Pages
{
    public class UserApplicationsModel : PageModel
    {
        private readonly SmukToolsApp.Data.Context _context;

        public UserApplicationsModel(SmukToolsApp.Data.Context context)
        {
            _context = context;
        }
        public bool ShowRejectMessage { get; set; } = false;

        public bool ShowSuccessMessage { get; set; } = false;
        public IList<ShiftApplications> ShiftApplications { get;set; }

        public async Task<IActionResult> OnGetAsync(int status)
        {
            if (HttpContext.Session.GetInt32("Id") == null)
            {
                return Redirect("/UserAuth/Login");
            }
            if (status == 2)
            {
                this.ShowSuccessMessage = true;
            }
            if (status == 3)
            {
                this.ShowRejectMessage = true;
            }
             var userId =(int) HttpContext.Session.GetInt32("Id");
            ShiftApplications = await _context.ShiftApplications
                .Include(s => s.Employee)
                .Include(s => s.Shift).Where(x=>x.EmployeeID==userId).ToListAsync();
            return Page();
        }
    }
}
