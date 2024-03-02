using System;
using System.ComponentModel.DataAnnotations;

namespace Intern_Admin_Collaboration.Models
{
    public class CertificateModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage="Invalid Email Address")]
        public string email { get; set; }

        [Required]
        public string intern_department { get; set; }

        [Required]
        public string certificate_name { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}/\d{2}/\d{4}$", ErrorMessage = "Date must be in format MM/dd/yyyy.")]
        public string issue_date { get; set; }


        [Required(ErrorMessage = "File is required")]
        [Display(Name = "Choose File")]
        public string CertificateFileName { get; set; }

    }
}
