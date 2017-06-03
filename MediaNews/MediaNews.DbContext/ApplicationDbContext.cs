using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MediaNews.Entities.Common;
using MediaNews.Entities.Models;
using MediaNews.DbContext.Migrations;

namespace MediaNews.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {

        public virtual IDbSet<Posts> Posts { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public ApplicationDbContext()
            : base("MediaNewsConnection", throwIfV1Schema: false)
          // : base("MediaNews-DevConnection", throwIfV1Schema: false)
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
