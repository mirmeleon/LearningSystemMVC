using System.ComponentModel.DataAnnotations;


namespace demos.Models.ViewModels.Users
{
   public class EditUserViewModel
    {
      
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
