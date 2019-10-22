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

                context.Shifts.AddRange(tools);

                var roles = new EmployeeRole[]
                {
                    new EmployeeRole
                {
                    Name = "Admin"
                }
                ,new EmployeeRole
                {
                     Name="Student"
                }
                };
                context.EmployeeRoles.AddRange(roles);
                context.SaveChanges();
                var users = new Employee[] {
                    new Employee()
                {
                    EmployeeNo = "emp1",
                    ContractStartingDate = DateTime.Now.AddDays(-30),
                    ContractEndingDate = DateTime.Now.AddDays(30),
                    EmployeeRoleId = context.EmployeeRoles.Select(x => x.ID).First(),
                    FirstName = "Admin",
                    LastName = "Admin",
                    Password = "123",
                    Username = "admin"
                },
                                    new Employee()
                {
                    EmployeeNo = "emp2",
                    ContractStartingDate = DateTime.Now.AddDays(-30),
                    ContractEndingDate = DateTime.Now.AddDays(30),
                    EmployeeRoleId = context.EmployeeRoles.Where(x=>x.Name=="Student").Select(x=>x.ID).First(),
                    FirstName = "Student",
                    LastName = "Student",
                    Password = "123",
                    Username = "student"
                }};
                context.Employees.AddRange(users);
                context.SaveChanges();
            }
        }
    }
}
