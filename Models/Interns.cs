
using System.ComponentModel.DataAnnotations;

namespace Intern_Admin_Collaboration.Models
{
    public class Interns
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string firstname { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        public int age { get; set; }

        [Required]
        public DateTime joindate { get; set; }

        [Required]
        public DateTime endingdate { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number.")]
        public string contact { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string collagename { get; set; }

        [Required]
        public string interndepart { get; set; }
    }
}
