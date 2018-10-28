using FriendOrganizer.Core.Entities;
using FriendOrganizer.Core.Interfaces;
using FriendOrganizer.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FriendOrganizer.Infrastructure.Repositories
{
    public class FriendRepository : IFriendRepository
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendRepository(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<IEnumerable<Friend>> GetAllAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            }
        }
    }
}
