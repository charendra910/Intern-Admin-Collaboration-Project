using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_Admin_Collaboration.Models
{
    public class ApprovedModel
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string firstname { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required]
        public string department { get; set; }

        [Required]
        public string reason { get; set; }

        [Required]
        public DateTime start_date { get; set; }

        [Required]
        public DateTime end_date { get; set; }

        [Required]
        public string status { get; set; }

        [Required]
        public DateTime applied_date { get; set; }
    }
}
