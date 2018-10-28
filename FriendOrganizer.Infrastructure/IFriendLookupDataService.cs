using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganizer.Core;

namespace FriendOrganizer.Infrastructure
{
    public interface IFriendLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}