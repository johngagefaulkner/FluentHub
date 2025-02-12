using FluentHub.Octokit.Queries.Repositories;
using FluentHub.App.Helpers;
using FluentHub.App.Models;
using FluentHub.App.Services;
using FluentHub.App.Utils;
using FluentHub.App.ViewModels.UserControls.Overview;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;

namespace FluentHub.App.ViewModels.Repositories.Issues
{
    public class IssueViewModel : ObservableObject
    {
        public IssueViewModel(IMessenger messenger = null, ILogger logger = null)
        {
            _messenger = messenger;
            _logger = logger;

            _timelineItems = new();
            TimelineItems = new(_timelineItems);

            LoadRepositoryIssuePageCommand = new AsyncRelayCommand(LoadRepositoryIssuePageAsync);
        }

        #region Fields and Properties
        private readonly IMessenger _messenger;
        private readonly ILogger _logger;

        private string _login;
        public string Login { get => _login; set => SetProperty(ref _login, value); }

        private string _name;
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        private int _number;
        public int Number { get => _number; set => SetProperty(ref _number, value); }

        private Repository _repository;
        public Repository Repository { get => _repository; set => SetProperty(ref _repository, value); }

        private RepositoryOverviewViewModel _repositoryOverviewViewModel;
        public RepositoryOverviewViewModel RepositoryOverviewViewModel { get => _repositoryOverviewViewModel; set => SetProperty(ref _repositoryOverviewViewModel, value); }

        private Issue _issueItem;
        public Issue IssueItem { get => _issueItem; private set => SetProperty(ref _issueItem, value); }

        private readonly ObservableCollection<object> _timelineItems;
        public ReadOnlyObservableCollection<object> TimelineItems { get; set; }

        private Exception _taskException;
        public Exception TaskException { get => _taskException; set => SetProperty(ref _taskException, value); }

        public IAsyncRelayCommand LoadRepositoryIssuePageCommand { get; }
        #endregion

        private async Task LoadRepositoryIssuePageAsync()
        {
            _messenger?.Send(new TaskStateMessaging(TaskStatusType.IsStarted));
            bool faulted = false;

            string _currentTaskingMethodName = nameof(LoadRepositoryIssuePageAsync);

            try
            {
                _currentTaskingMethodName = nameof(LoadRepositoryAsync);
                await LoadRepositoryAsync(Login, Name);

                _currentTaskingMethodName = nameof(LoadRepositoryOneIssueAsync);
                await LoadRepositoryOneIssueAsync(Login, Name);
            }
            catch (Exception ex)
            {
                TaskException = ex;
                faulted = true;

                _logger?.Error(_currentTaskingMethodName, ex);
                throw;
            }
            finally
            {
                SetCurrentTabItem();
                _messenger?.Send(new TaskStateMessaging(faulted ? TaskStatusType.IsFaulted : TaskStatusType.IsCompletedSuccessfully));
            }
        }

        private async Task LoadRepositoryOneIssueAsync(string owner, string name)
        {
            IssueQueries issueQueries = new();
            IssueEventQueries queries = new();
            _timelineItems.Clear();

            IssueItem = await issueQueries.GetAsync(owner, name, Number);

            var bodyComment = await issueQueries.GetBodyAsync(owner, name, Number);
            _timelineItems.Add(bodyComment);

            var issueEvents = await queries.GetAllAsync(owner, name, Number);
            foreach (var item in issueEvents)
                _timelineItems.Add(item);
        }

        private async Task LoadRepositoryAsync(string owner, string name)
        {
            RepositoryQueries queries = new();
            Repository = await queries.GetDetailsAsync(owner, name);

            RepositoryOverviewViewModel = new()
            {
                Repository = Repository,
                RepositoryName = Repository.Name,
                RepositoryOwnerLogin = Repository.Owner.Login,
                ViewerSubscriptionState = Repository.ViewerSubscription?.Humanize(),

                SelectedTag = "issues",
            };
        }

        private void SetCurrentTabItem()
        {
            var provider = App.Current.Services;
            INavigationService navigationService = provider.GetRequiredService<INavigationService>();

            var currentItem = navigationService.TabView.SelectedItem.NavigationHistory.CurrentItem;
            currentItem.UserLogin = Repository.Owner.Login;
            currentItem.RepositoryName = Repository.Name;
            currentItem.Header = $"{IssueItem.Title} · #{IssueItem.Number}";
            currentItem.Description = currentItem.Header;
            currentItem.Icon = new ImageIconSource
            {
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Issues.png"))
            };
        }
    }
}
