using demos.Models;
using demos.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace demos.Data
{
    using System.Data.Entity;

    public class DemoContext : IdentityDbContext<ApplicationUser>
    {
      
        public DemoContext()
            : base("data source=.;initial catalog=DemoContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Course> Courses { get; set; }


        public static DemoContext Create()
        {
            return new DemoContext();
        }
    }



}