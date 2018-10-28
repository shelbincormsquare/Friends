using FriendOrganizer.Core.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace FriendOrganizer.Infrastructure.Persistence
{
    public class FriendOrganizerDbContext:DbContext
    {
        public FriendOrganizerDbContext(): base("FriendOrganizerDbContext")
        {

        }

        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
