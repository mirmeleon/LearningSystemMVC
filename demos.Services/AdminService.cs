using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using demos.Models;
using demos.Models.BindingModels.Admin;
using demos.Models.EntityModels;
using demos.Models.ViewModels.adminArea;
using demos.Models.ViewModels.AdminArea;
using demos.Models.ViewModels.Courses;
using demos.Services.Contracts;

namespace demos.Services
{
   public class AdminService : Service, IAdminService
   {
        public void CreateCourse(CreateCourseBm createBm)
        {
           Course course = new Course();
            course = Mapper.Map<CreateCourseBm, Course>(createBm);
            if (course.Trainer == null)
            {
               course.Trainer = this.Context.Users.FirstOrDefault();
            }
            this.Context.Courses.Add(course);
            this.Context.SaveChanges();
        }

        public AdminPageViewModel GetAllCourses()
        {
            
            AdminPageViewModel page = new AdminPageViewModel();
            IEnumerable<Course> courses = this.Context.Courses;
            IEnumerable<Student> students = this.Context.Students;
            IEnumerable<CourseViewModel> coursesVms = Mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>> (courses);
            IEnumerable<AdminPageUserViewModel> userVms = Mapper.Map<IEnumerable<Student>, IEnumerable<AdminPageUserViewModel>>(students);
            page.Users = userVms;
            page.Courses = coursesVms;
            return page;
        }

        public IEnumerable<AllUsersViewModel> GetUsers()
        {
           var users = this.Context.Users;
            IEnumerable<AllUsersViewModel> mapped = Mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<AllUsersViewModel>>(users);

            return mapped;
        }
    }
}
