using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using demos.Models;
using demos.Models.BindingModels.Users;
using demos.Models.EntityModels;
using demos.Models.ViewModels.Users;
using demos.Services.Contracts;

namespace demos.Services
{
  public class UsersService : Service, IUsersService
  {
        public Student GetCurrentStudent(string userName)
        {
           var user = this.Context.Users.FirstOrDefault(u => u.UserName == userName);
            Student currentStudent = this.Context.Students.FirstOrDefault(stud => stud.User.Id == user.Id);
            return currentStudent;

        }

        public void SubscribeUser(int courseId, Student student)
        {
            Course wantedCourse = this.Context.Courses.Find(courseId);
            student.Courses.Add(wantedCourse);
            this.Context.SaveChanges();
        }

        public ProfileViewModel GetProfileVm(string userName)
        {
        
            ApplicationUser currUser = this.Context.Users.FirstOrDefault(us => us.UserName == userName);
            ProfileViewModel vm = Mapper.Map<ApplicationUser, ProfileViewModel>(currUser);
            Student student = this.Context.Students.FirstOrDefault(st => st.User.Id == currUser.Id);
            vm.EnrolledCourses = Mapper.Map<IEnumerable<Course>, IEnumerable<UserCourseViewModel>>(student.Courses);
            return vm;
        }

        public EditUserViewModel GetEditViewModel(string currentUserUsername)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(app => app.UserName == currentUserUsername);
            EditUserViewModel editUserVm = Mapper.Map<ApplicationUser, EditUserViewModel>(user);
            return editUserVm;
        }

        public void EditUser(EditUserBm bind, string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(app => app.UserName == userName);
            user.Name = bind.Name;
            user.Email = bind.Email;

           this.Context.SaveChanges();
        }
    }
}
