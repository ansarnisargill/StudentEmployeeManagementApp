using System.ComponentModel.DataAnnotations;

namespace StudentEmployeeManagementApp.Models
{
        public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeNo { get; set; }
        public DataType ContractStartingDate { get; set; }
        public DataType ContractEndingDate { get; set; }
        public int EmployeeRoleId { get; set; }
        public EmployeeRole EmployeeRole { get; set; }

    }
    public class EmployeeRole
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}