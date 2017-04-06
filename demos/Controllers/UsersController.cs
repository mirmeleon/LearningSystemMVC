using System.Web.Mvc;
using demos.Models.BindingModels.Users;
using demos.Models.EntityModels;
using demos.Models.ViewModels.Users;
using demos.Services.Contracts;

namespace demos.Controllers
{
    [Authorize(Roles = "student, admin")]
    [RoutePrefix("Users")]
    public class UsersController : Controller
    {
        private IUsersService service;

        public UsersController(IUsersService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("subscribe")]
        public ActionResult Subscribe(int courseId)
        {
            string userName = User.Identity.Name;
            Student student = this.service.GetCurrentStudent(userName);
            this.service.SubscribeUser(courseId, student);
            return this.Redirect("Profile");
        }

        [HttpGet]
        [Route("profile")]
        public ActionResult Profile()
        {
            string currentUserUsername = this.User.Identity.Name;
            ProfileViewModel userProfile =  this.service.GetProfileVm(currentUserUsername);
            return this.View(userProfile);
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit()
        {
            string currentUserUsername = this.User.Identity.Name;
            EditUserViewModel editUser = this.service.GetEditViewModel(currentUserUsername);
            return this.View(editUser);
        }

        [HttpPost]
        [Route("edit")]
        public ActionResult Edit(EditUserBm bind)
        {
            if (this.ModelState.IsValid)
            {
                string userName = this.User.Identity.Name;
                this.service.EditUser(bind, userName);
                return this.Redirect("Profile");
            }

            string currentUserUsername = this.User.Identity.Name;
            EditUserViewModel editUser = this.service.GetEditViewModel(currentUserUsername);
            return this.View(editUser);
        }
    }
}