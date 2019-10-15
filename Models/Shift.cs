using System;

namespace StudentEmployeeManagementApp.Models
{
    public class Shift
    {
        public int ID { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public bool IsMorningShift { get; set; }

    }
}