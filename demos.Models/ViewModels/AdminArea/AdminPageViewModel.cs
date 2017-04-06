
using System.Collections.Generic;
using demos.Models.ViewModels.Courses;

namespace demos.Models.ViewModels.AdminArea
{
  public class AdminPageViewModel
    {
        public IEnumerable<CourseViewModel> Courses { get; set; }

        public IEnumerable<AdminPageUserViewModel> Users{ get; set; }
    }
}
