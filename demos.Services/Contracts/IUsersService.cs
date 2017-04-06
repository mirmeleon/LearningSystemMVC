using demos.Models.BindingModels.Users;
using demos.Models.EntityModels;
using demos.Models.ViewModels.Users;

namespace demos.Services.Contracts
{
    public interface IUsersService
    {
        Student GetCurrentStudent(string userName);
        void SubscribeUser(int courseId, Student student);
        ProfileViewModel GetProfileVm(string userName);
        EditUserViewModel GetEditViewModel(string currentUserUsername);
        void EditUser(EditUserBm bind, string userName);
    }
}