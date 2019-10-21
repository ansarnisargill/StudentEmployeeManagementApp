using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmukToolsApp.Data;
using SmukToolsApp.Models;
using SmukToolsProject.Models;

namespace SmukToolsApp.Pages
{
    public class IndexModel : PageModel
    {
    private Context _context;

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetInt32("Id") != null)
            {
                return Page();
            }
            else
            {
               return Redirect("/UserAuth/Login");
            }
        }
        public IndexModel(Context contex)
        {
            _context=contex;
        }
    }
}
