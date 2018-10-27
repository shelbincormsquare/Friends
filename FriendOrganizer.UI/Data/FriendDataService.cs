using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Shelbin", LastName = "Kidangan", Email = "hsjdds@djskdj" };
            yield return new Friend { FirstName = "Shimnas", LastName = "Sidque", Email = "hsjd1ds@djskdj" };
            yield return new Friend { FirstName = "Shreya", LastName = "Uday", Email = "hsjdd1212s@djskdj" };
            yield return new Friend { FirstName = "Niket", LastName = "Soni", Email = "hsjd122ds@djskdj" };
        }
    }
}
