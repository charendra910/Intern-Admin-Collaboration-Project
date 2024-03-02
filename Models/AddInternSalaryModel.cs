using System.ComponentModel.DataAnnotations;

namespace Intern_Admin_Collaboration.Models
{
    public class AddInternSalaryModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Invalid year format.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Month is required.")]
        [RegularExpression(@"^(0?[1-9]|1[0-2])$", ErrorMessage = "Invalid month format.")]
        public string Month { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string Status { get; set; }
    }
}
