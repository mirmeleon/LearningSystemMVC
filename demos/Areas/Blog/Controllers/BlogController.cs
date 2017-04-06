using System.Collections.Generic;
using System.Web.Mvc;
using demos.Models.BindingModels.Blog;
using demos.Models.ViewModels.Blog;
using demos.Services.Contracts;

namespace demos.Areas.Blog.Controllers
{
    // [MyAuthorize(Roles = "admin, student, trainer, blogAuthor")]
    [RouteArea("Blog")]
    [Authorize(Roles = "student")]
    public class BlogController : Controller
    {
        private IBlogService service;

        public BlogController(IBlogService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("Articles")]
        public ActionResult Articles()
        {
            IEnumerable<ArticleViewModel> vms = this.service.GetAllArticles();
            return View(vms);
        }

        [HttpGet]
        [Route("articles/add")]
        [Authorize(Roles = "blogAuthor, admin")]
        public ActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Route("articles/add")]
        [Authorize(Roles = "blogAuthor, admin")]
        public ActionResult Add(AddArticleBm addArticleBm)
        {
            if (this.ModelState.IsValid)
            {
                string username = this.User.Identity.Name;
                this.service.AddArticle(addArticleBm, username);
                return this.RedirectToAction("Articles");
            }

            return this.View();
        }
    }
}