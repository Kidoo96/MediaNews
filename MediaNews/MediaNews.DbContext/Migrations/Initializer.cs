using MediaNews.Entities.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Project.Common;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MediaNews.DbContext.Migrations
{
    internal class Initializer
    {
        internal static void SeedRoles(ApplicationDbContext context)
        {
            string[] roles =
            {
                "Администратор",
                "Журналист",
                "Потребител",
                "Гост"
            };

            foreach (var role in roles)
            {
                var roleStore = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!context.Roles.Any(r => r.Name == role))
                {
                    roleStore.Create(new IdentityRole(role));
                }
            }
        }

        internal static void SeedUser(ApplicationDbContext context)
        {
            string userName = "Admin";

            var hasher = new PasswordHasher();

            var user = new User
            {
                UserName = userName,
                PasswordHash = hasher.HashPassword("admin123"),
                Email = "admin@medianews.bg",
                EmailConfirmed = true,
                SecurityStamp = new CustomId().ToString()
            };

            user.Roles.Add(new IdentityUserRole { RoleId = "cf71d4c6-61f9-4cf4-9b51-9cc3af690907", UserId = user.Id });
            context.Users.AddOrUpdate(user);
        }
    }
}