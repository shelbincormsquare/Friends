using FriendOrganizer.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.Core.Interfaces
{
    public interface IFriendRepository
    {
        Task<IEnumerable<Friend>> GetAllAsync();
    }
}
