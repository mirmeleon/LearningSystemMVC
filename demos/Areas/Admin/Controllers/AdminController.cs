using System.Collections.Generic;
using System.Web.Mvc;
using demos.Attributes;
using demos.Models.BindingModels.Admin;
using demos.Models.ViewModels.adminArea;
using demos.Models.ViewModels.AdminArea;
using demos.Services.Contracts;

namespace demos.Areas.Admin.Controllers
{
    [MyAuthorize(Roles = "admin")]
  //  [Authorize(Roles = "admin, student")] toj polzva toia autorize
    [RouteArea("admin")]
    public class AdminController : Controller
    {
        private IAdminService service;

        public AdminController(IAdminService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route]
        public ActionResult Index()
        {
            AdminPageViewModel courses = this.service.GetAllCourses();
            return View(courses);
        }

        [HttpGet]
        [Route("createCourse")]
        public ActionResult CreateCourse()
        {

            return View();
        }

        [HttpPost]
        [Route("createCourse")]
        public ActionResult CreateCourse([Bind(Include = "Name, Description, StartDate, EndDate, TreinerId, Treiner")]CreateCourseBm createBm)
        {
            if (this.ModelState.IsValid)
            {
                this.service.CreateCourse(createBm);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("setRoles")]
        public ActionResult SetRoles()
        {
            IEnumerable<AllUsersViewModel> users = this.service.GetUsers();
            return View(users);
        }

        [HttpGet]
        [Route("courses/{id}/edit")]
        public ActionResult EditCourse(int id)
        {
            //todo
            return this.View();
        }

        [HttpGet]
        [Route("users/{id}/edit")]
        public ActionResult EditUser(int id)
        {
            //todo moje bi da go sleia sus setRoles
            return this.View();
        }
    }
}