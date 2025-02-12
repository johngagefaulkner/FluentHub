// Copyright (c) FluentHub
// Licensed under the MIT License. See the LICENSE.

using FluentHub.App.Data.Parameters;
using FluentHub.App.Services;
using FluentHub.App.ViewModels.Repositories.PullRequests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;

namespace FluentHub.App.Views.Repositories.PullRequests
{
    public sealed partial class FileChangesPage : LocatablePage
    {
        public FileChangesViewModel ViewModel { get; }
        private readonly INavigationService _navigation;

        public FileChangesPage()
            : base(NavigationBarPageKind.Repository, NavigationBarItemKey.PullRequests)
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<FileChangesViewModel>();
            _navigation = provider.GetRequiredService<INavigationService>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var param = e.Parameter as FrameNavigationParameter;
            ViewModel.Login = param.UserLogin;
            ViewModel.Name = param.RepositoryName;
            ViewModel.Number = param.Number;

            var command = ViewModel.LoadRepositoryPullRequestFileChangesPageCommand;
            if (command.CanExecute(null))
                command.Execute(null);
        }
    }
}
