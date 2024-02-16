using System.ComponentModel.DataAnnotations;

namespace Intern_Admin_Collaboration.Models
{
    public class IALogin
    {
       
        public string Email { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        public bool KeepLoggedIn { get; set; }
    }
}
