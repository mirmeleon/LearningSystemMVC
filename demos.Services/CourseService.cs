using AutoMapper;
using demos.Models.EntityModels;
using demos.Models.ViewModels.Courses;
using demos.Services.Contracts;

namespace demos.Services
{
  public  class CourseService : Service, ICourseService
  {
        public DetailsCourseViewModel GetDetails(int id)
        {
            Course course = this.Context.Courses.Find(id);
            if (course == null)
            {
                return null;
            }
            else
            {
                DetailsCourseViewModel mappedCourse = Mapper.Map<Course, DetailsCourseViewModel>(course);

                return mappedCourse;
            }
          
        }
    }
}
