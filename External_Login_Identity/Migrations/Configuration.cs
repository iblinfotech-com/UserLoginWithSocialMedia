namespace External_Login_Identity.Migrations
{
    using External_Login_Identity.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;


    internal sealed class Configuration : DbMigrationsConfiguration<External_Login_Identity.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(External_Login_Identity.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "User" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "Admin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "Admin", Email = "Admin@SomeDomain.com", EmailConfirmed = true };

                manager.Create(user, "Admin123");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "User1"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "User1", Email = "User1@SomeDomain.com", EmailConfirmed = true };

                manager.Create(user, "User123");
                manager.AddToRole(user.Id, "User");
            }

            if (!context.Users.Any(u => u.UserName == "User2"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "User2", Email = "User2@SomeDomain.com", EmailConfirmed = true };

                manager.Create(user, "User123");
                manager.AddToRole(user.Id, "User");
            }

            if (!context.Users.Any(u => u.UserName == "User3"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "User3", Email = "User3@SomeDomain.com", EmailConfirmed = true };

                manager.Create(user, "User123");
                manager.AddToRole(user.Id, "User");
            }

        }
    }
}