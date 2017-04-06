using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using demos.Models;
using demos.Models.BindingModels.Admin;
using demos.Models.BindingModels.Blog;
using demos.Models.EntityModels;
using demos.Models.ViewModels.adminArea;
using demos.Models.ViewModels.AdminArea;
using demos.Models.ViewModels.Blog;
using demos.Models.ViewModels.Courses;
using demos.Models.ViewModels.Users;

namespace demos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMapper();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapper()
        {
          Mapper.Initialize(expression =>
          {
              //binding models
              expression.CreateMap<CreateCourseBm, Course>();
              expression.CreateMap<AddArticleBm, Article>();
            
              //view models
              expression.CreateMap<Course, AllCoursesViewModel>();
              expression.CreateMap<Course, CourseViewModel>();
              expression.CreateMap<Course, DetailsCourseViewModel>();
              expression.CreateMap<ApplicationUser, ProfileViewModel>();
              expression.CreateMap<Course, UserCourseViewModel>();
              expression.CreateMap<ApplicationUser, EditUserViewModel>();
              expression.CreateMap<Article, ArticleViewModel>();
              expression.CreateMap<ApplicationUser, ArticleAuthorViewModel>();
        
              expression.CreateMap<Student, AdminPageUserViewModel>()
              .ForMember(m=>m.Name, 
              config =>
              config.MapFrom(stu => stu.User.Name));
              //tuka may niama da go mapne pravilno
              expression.CreateMap<ApplicationUser, AllUsersViewModel>();

          });
        }
    }
}
