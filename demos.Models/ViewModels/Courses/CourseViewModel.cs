using System;
using System.ComponentModel.DataAnnotations;

namespace demos.Models.ViewModels.Courses
{
  public  class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Start Date:")]
        public DateTime StartDate { get; set; }

       
    }
}
