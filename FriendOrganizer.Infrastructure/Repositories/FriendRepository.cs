using FriendOrganizer.Core.Entities;
using FriendOrganizer.Core.Interfaces;
using FriendOrganizer.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace FriendOrganizer.Infrastructure.Repositories
{
    public class FriendRepository : IFriendRepository
    {
        public IEnumerable<Friend> GetAll()
        {
            using (var ctx = new FriendOrganizerDbContext())
            {
                return ctx.Friends.AsNoTracking().ToList();
            }
        }
    }
}
