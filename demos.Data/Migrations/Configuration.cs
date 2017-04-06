using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace demos.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<demos.Data.DemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DemoContext context)
        {
            if (!context.Roles.Any(role => role.Name == "student"))
            {
                RoleStore<IdentityRole> store = new RoleStore<IdentityRole>(context);
                
                var manager = new RoleManager<IdentityRole>(store);
                //dobaviame si nashata nova rolia, triabva da e sus sushtoto ime kato v if-a gore
                var role = new IdentityRole("student");
                manager.Create(role);

            }

            if (!context.Roles.Any(role => role.Name == "admin"))
            {
                RoleStore<IdentityRole> store = new RoleStore<IdentityRole>(context);

                var manager = new RoleManager<IdentityRole>(store);
                //dobaviame si nashata nova rolia, triabva da e sus sushtoto ime kato v if-a gore
                var role = new IdentityRole("admin");
                manager.Create(role);

            }

            if (!context.Roles.Any(role => role.Name == "trainer"))
            {
                RoleStore<IdentityRole> store = new RoleStore<IdentityRole>(context);

                var manager = new RoleManager<IdentityRole>(store);
                //dobaviame si nashata nova rolia, triabva da e sus sushtoto ime kato v if-a gore
                var role = new IdentityRole("trainer");
                manager.Create(role);

            }
            if (!context.Roles.Any(role => role.Name == "blogAuthor"))
            {
                RoleStore<IdentityRole> store = new RoleStore<IdentityRole>(context);

                var manager = new RoleManager<IdentityRole>(store);
                //dobaviame si nashata nova rolia, triabva da e sus sushtoto ime kato v if-a gore
                var role = new IdentityRole("blogAuthor");
                manager.Create(role);

            }
        }
    }
}
