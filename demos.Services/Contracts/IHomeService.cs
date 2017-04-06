using System.Collections.Generic;
using demos.Models.ViewModels.Courses;

namespace demos.Services.Contracts
{
    public interface IHomeService
    {
        IEnumerable<CourseViewModel> GetAllCourses();
    }
}