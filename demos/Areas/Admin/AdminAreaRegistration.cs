using System.Web.Mvc;

namespace demos.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
             context.Routes.MapMvcAttributeRoutes();
        }
    }
}