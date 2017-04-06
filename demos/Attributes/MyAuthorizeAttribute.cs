using System.Linq;
using System.Web.Mvc;

namespace demos.Attributes
{
    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            
            var roles = this.Roles.Split(',');
     
            if (filterContext.HttpContext.Request.IsAuthenticated && !this.Roles.Split(',').Any(role => filterContext.HttpContext.User.IsInRole(role)))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/MyUnautorised.cshtml"
                };
            }
            else
            {
                //ey tva ne sum sigurna taka li e
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}