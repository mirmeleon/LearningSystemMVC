using System.Collections.Generic;
using demos.Models.BindingModels.Admin;
using demos.Models.ViewModels.adminArea;
using demos.Models.ViewModels.AdminArea;

namespace demos.Services.Contracts
{
    public interface IAdminService
    {
        void CreateCourse(CreateCourseBm createBm);
        AdminPageViewModel GetAllCourses();
        IEnumerable<AllUsersViewModel> GetUsers();
    }
}