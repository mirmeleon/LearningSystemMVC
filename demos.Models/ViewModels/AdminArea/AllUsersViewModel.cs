using Microsoft.AspNet.Identity.EntityFramework;

namespace demos.Models.ViewModels.adminArea
{
  public class AllUsersViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

       public IdentityRole Role { get; set; }

      
    }
}
