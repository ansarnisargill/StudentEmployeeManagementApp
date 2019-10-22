using StudentEmployeeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeShiftManagement.Models
{
    public class ShiftApplications
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int ShiftID { get; set; }
        public Shift Shift { get; set; }
    }
}
