using FriendOrganizer.Core.Entities;
using System.Threading.Tasks;

namespace FriendOrganizer.Core.Interfaces
{
    public interface IFriendRepository
    {
        Task<Friend> GetByIdAsync(int friendId);
    }
}
