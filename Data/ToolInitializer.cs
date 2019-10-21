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
                var role = new EmployeeRole()
                {
                    Name = "Admin"
                };
                context.EmployeeRoles.Add(role);
                context.SaveChanges();
                var users = new Employee()
                {
                    EmployeeNo = "emp1",
                    ContractStartingDate = DateTime.Now.AddDays(-30),
                    ContractEndingDate = DateTime.Now.AddDays(30),
                    EmployeeRoleId = context.EmployeeRoles.Select(x => x.ID).First(),
                    FirstName = "Admin",
                    LastName = "Admin",
                    Password = "123",
                    Username = "admin"
                };
                context.Employees.Add(users);
                context.SaveChanges();
            }
        }
    }
}
