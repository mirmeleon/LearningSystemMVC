using System.ComponentModel.DataAnnotations;

namespace demos.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}