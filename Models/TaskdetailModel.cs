using System;
using System.ComponentModel.DataAnnotations;

namespace Intern_Admin_Collaboration.Models
{
    public class TaskdetailModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Task_Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}/\d{2}/\d{4}$", ErrorMessage = "Date must be in format MM/dd/yyyy.")]
        public string Assign_Date { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}/\d{2}/\d{4}$", ErrorMessage = "Date must be in format MM/dd/yyyy.")]
        public string Deadline_Date { get; set; }
    }
}
