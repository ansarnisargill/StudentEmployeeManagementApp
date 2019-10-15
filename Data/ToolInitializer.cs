using SmukToolsApp.Models;
using StudentEmployeeManagementApp.Models;
using System;
using System.Linq;

namespace SmukToolsApp.Data
{
    public class ToolInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            if (!context.Shifts.Any())
            {
                var tools = new Shift[]
                {
                    new Shift{  StartingTime=DateTime.Now,EndingTime=DateTime.Now.AddHours(3),IsMorningShift=true}
                };
                foreach (var item in tools)
                {
                    context.Shifts.Add(item);
                }
                context.SaveChanges();
            }
        }
    }
}
