using FluentHub.App.Helpers;
using FluentHub.App.Models;
using FluentHub.App.Utils;

namespace FluentHub.App.ViewModels.UserControls.BlockButtons
{
    public class UserBlockButtonViewModel : ObservableObject
    {
        private User _user;
        public User User { get => _user; set => SetProperty(ref _user, value); }
    }
}
