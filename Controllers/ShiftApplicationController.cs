using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeShiftManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmukToolsApp.Data;

namespace EmployeeShiftManagement.Controllers
{
    public class ShiftApplicationController : Controller
    {
        private Context _context;
        [Route("ShiftApplication/Index")]
        public ActionResult Index(int ShiftId)
        {
            var userId=HttpContext.Session.GetInt32("Id");
            if (_context.ShiftApplications.Any(x => x.ShiftID == ShiftId && x.EmployeeID == userId))
            {
                return Redirect("/UserApplications/3");
            }
            else
            {
                var application = new ShiftApplications()
                {
                    EmployeeID = (int)userId,
                    ShiftID = ShiftId
                };
                _context.ShiftApplications.Add(application);
                _context.SaveChanges();
                return Redirect("/UserApplications/2");
                
            }
            
        }
        public ShiftApplicationController(Context context)
        {
            this._context = context;
        }
    }
}