using System;

namespace demos.Models.ViewModels.adminArea
{
   public class AllCoursesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser Trainer { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
