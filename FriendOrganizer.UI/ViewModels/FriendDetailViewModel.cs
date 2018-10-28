using FriendOrganizer.Core.Entities;
using FriendOrganizer.Core.Interfaces;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModels
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private IFriendRepository _dataService;

        public FriendDetailViewModel(IFriendRepository dataService)
        {
            _dataService = dataService;
        }

        public async Task LoadAsync(int friendId)
        {
            Friend = await _dataService.GetByIdAsync(friendId);
        }

        private Friend _friend;

        public Friend Friend
        {
            get { return _friend; }
            set
            {
                _friend = value;
                OnPropertyChanged();
            }
        }

    }
}
