using FluentHub.App.Services;
using FluentHub.App.ViewModels.Users;
using FluentHub.Core.Data.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;

namespace FluentHub.App.Views.Users
{
    public sealed partial class StarredReposPage : LocatablePage
    {
        public StarredReposPage()
            : base(NavigationBarPageKind.User, NavigationBarItemKey.Stars)
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<StarredReposViewModel>();
        }

        public StarredReposViewModel ViewModel { get; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var param = e.Parameter as Models.FrameNavigationParameter;
            _ = param ?? throw new ArgumentNullException("param");

            ViewModel.Login = param.Login;

            if (param.Parameters.ElementAtOrDefault(0) as string is "AsViewer")
            {
                ViewModel.DisplayTitle = true;
            }

            var command = ViewModel.LoadUserStarredRepositoriesPageCommand;
            if (command.CanExecute(null))
                command.Execute(null);
        }
    }
}
