using System.ComponentModel.DataAnnotations;

namespace Intern_Admin_Collaboration.Models
{
    public class AddEventDetailsModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Event Name is required.")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Registration Link is required.")]
        public string RegistrationLink { get; set; }

        [Required(ErrorMessage = "Start Date is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string Status { get; set; }

        // Additional property for poster upload
        [Required(ErrorMessage = "Please upload a poster.")]
        public string PosterFileName { get; set; }
    }
}
