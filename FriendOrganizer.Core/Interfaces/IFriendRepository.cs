using FriendOrganizer.Core.Entities;
using System.Collections.Generic;

namespace FriendOrganizer.Core.Interfaces
{
    public interface IFriendRepository
    {
        IEnumerable<Friend> GetAll();
    }
}
