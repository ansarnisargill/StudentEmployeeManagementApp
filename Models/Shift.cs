using System;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployeeManagementApp.Models
{
    public class Shift
    {

        [Key]
        public int ID { get; set; }
        [Display(Name = "Shift Start")]
        [Required]
        public TimeSpan StartingTime { get; set; }
        [Display(Name = "Shift End")]
        [Required]
        public TimeSpan EndingTime { get; set; }
        [Display(Name = "Is Morning Shift?")]
        [Required]
        public bool IsMorningShift { get; set; }
        [Display(Name = "Min Requirement")]
        [Required]
        public int MinimumRequirement { get; set; }
        [Display(Name = "Max Requirement")]
        [Required]
        public int MaximumRequirement { get; set; }
        [Display(Name = "Shift Date")]
        public DateTime Date { get; set; }
    }
}