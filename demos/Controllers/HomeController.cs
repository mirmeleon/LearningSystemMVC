using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using demos.Models.ViewModels.Courses;
using demos.Services.Contracts;

namespace demos.Controllers
{
    [Authorize(Roles = "student, admin")]
    public class HomeController : Controller
    {
        private IHomeService service;

        public HomeController(IHomeService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route]
        public ActionResult Index()
        {
            IEnumerable<CourseViewModel> courses = this.service.GetAllCourses();
            return View(courses);

        }
       
        [HttpGet]
        [AllowAnonymous]
        [Route("about")]
        public ActionResult About()
        {
            
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("upload")]
        public ActionResult UploadFile()
        {

            return this.View();
        }


        [HttpPost]
        [Authorize(Roles = "admin")]
        [Route("upload")]
        [ActionName("UploadFile")]
        public ActionResult Upload()
        {
            
            HttpPostedFileBase file = this.Request.Files[0];
            string fileName = Path.GetFileName(file.FileName); 
            string path = Path.Combine(Server.MapPath("~/UploadedFiles"), fileName); 

            file.SaveAs(path);
            return this.RedirectToAction("Index");
        }
    }
}