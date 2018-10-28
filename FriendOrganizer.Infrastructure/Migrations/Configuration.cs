namespace FriendOrganizer.Infrastructure.Migrations
{
    using FriendOrganizer.Core.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.Infrastructure.Persistence.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.Infrastructure.Persistence.FriendOrganizerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Friends.AddOrUpdate(f => f.FirstName,
           new Friend { FirstName = "Shelbin", LastName = "Kidangan", Email = "hsjdds@djskdj" },
           new Friend { FirstName = "Shimnas", LastName = "Sidque", Email = "hsjd1ds@djskdj" },
           new Friend { FirstName = "Shreya", LastName = "Uday", Email = "hsjdd1212s@djskdj" },
           new Friend { FirstName = "Niket", LastName = "Soni", Email = "hsjd122ds@djskdj" });
        }
    }
}
