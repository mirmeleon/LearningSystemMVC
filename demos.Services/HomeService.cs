using System.Collections.Generic;
using AutoMapper;
using demos.Models.EntityModels;
using demos.Models.ViewModels.Courses;
using demos.Services.Contracts;

namespace demos.Services
{
   public class HomeService : Service, IHomeService
   {
        public IEnumerable<CourseViewModel> GetAllCourses()
        {
           
            IEnumerable<Course> courses = this.Context.Courses;

          
                IEnumerable<CourseViewModel> mappedCourses = Mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>>(courses);
                return mappedCourses;
           
        }

     
    }
}
