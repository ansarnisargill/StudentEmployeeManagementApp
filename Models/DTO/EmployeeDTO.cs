using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeShiftManagement.Models.DTO
{
    public class EmployeeDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class ShiftDTO
    {
        public int ID { get; set; }
        public bool IsMorningShift { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<EmployeeDTO> Employees { get; set; }
    }
}
