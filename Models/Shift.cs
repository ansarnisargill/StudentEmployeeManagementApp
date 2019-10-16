using System;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployeeManagementApp.Models
{
    public class Shift
    {

        [Key]
        public int ID { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public bool IsMorningShift { get; set; }
        public int MinimumRequirement { get; set; }
        public int MaximumRequirement { get; set; }

    }
}