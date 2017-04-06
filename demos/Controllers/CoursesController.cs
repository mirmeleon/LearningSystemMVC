using System.Web.Mvc;
using demos.Models.ViewModels.Courses;
using demos.Services.Contracts;

namespace demos.Controllers
{
    [Authorize(Roles = "student, admin")]
    [RoutePrefix("courses")]
    public class CoursesController : Controller
    {
        private ICourseService service;
        public CoursesController(ICourseService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("details/{id}")]
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
           
            DetailsCourseViewModel detailedCourse = this.service.GetDetails(id);
            if (detailedCourse == null)
            {
                return this.HttpNotFound();
            }

            return View(detailedCourse);
        }

      

    }
}