using demos.Models.ViewModels.Courses;

namespace demos.Services.Contracts
{
    public interface ICourseService
    {
        DetailsCourseViewModel GetDetails(int id);
    }
}