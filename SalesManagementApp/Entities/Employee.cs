using System.ComponentModel.DataAnnotations;

namespace SalesManagementApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? ReportToEmpId { get; set; }
        public string ImagePath { get; set; }
        public int EmployeeJobTitleId { get; set; }

    }
}
