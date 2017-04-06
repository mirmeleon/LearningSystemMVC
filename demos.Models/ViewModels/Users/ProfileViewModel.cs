using System;
using System.Collections.Generic;

namespace demos.Models.ViewModels.Users
{
   public class ProfileViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public IEnumerable<UserCourseViewModel> EnrolledCourses { get; set; }
    }
}
