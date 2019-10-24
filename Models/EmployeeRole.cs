using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using EmployeeShiftManagement.Models;
using System.Collections.Generic;

namespace StudentEmployeeManagementApp.Models
{
        public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Username")]
[Required]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Employee No")]
        [Required]
        public string EmployeeNo { get; set; }
        [Display(Name = "Contract Start Date")]
        [Required]
        public DateTime ContractStartingDate { get; set; }
        [Display(Name = "Contract End Date")]
        [Required]
        public DateTime ContractEndingDate { get; set; }
        public int EmployeeRoleId { get; set; }
        public EmployeeRole EmployeeRole { get; set; }
        public List<ShiftApplications> ShiftsApplications { get; set; }


    }
    public class EmployeeRole
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Role Name")]
        [Required]
        public string Name { get; set; }
    }
}