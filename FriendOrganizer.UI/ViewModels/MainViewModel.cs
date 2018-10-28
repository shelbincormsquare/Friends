using FriendOrganizer.Core.Entities;
using FriendOrganizer.Core.Interfaces;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendRepository _friendRepository;
        private Friend _selectedFriend;


        public MainViewModel(IFriendRepository friendRepository)
        {
            Friends = new ObservableCollection<Friend>(); ;
            _friendRepository = friendRepository;
        }

        public async Task LoadAsync()
        {
            var friends = await _friendRepository.GetAllAsync();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;
                OnPropertyChanged();
            }
        }


    }
}
