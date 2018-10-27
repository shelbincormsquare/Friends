using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Shelbin", LastName = "Kidangan" };
            yield return new Friend { FirstName = "Shimnas", LastName = "Sidque" };
            yield return new Friend { FirstName = "Shreya", LastName = "Uday" };
            yield return new Friend { FirstName = "Niket", LastName = "Soni" };
        }
    }
}
