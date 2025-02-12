using Microsoft.UI.Xaml.Data;

namespace FluentHub.App.Converters
{
    public class IssueCommentToIssueCommentBlockViewModelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var ic = value as IssueComment;

            var issueCommentBlockViewModel = new ViewModels.UserControls.IssueCommentBlockViewModel()
            {
                IssueComment = ic,
            };

            // Parse reactions nodes
            foreach (var reaction in ic.Reactions.Nodes)
            {
                _ = reaction.Content switch
                {
                    ReactionContent.ThumbsUp => issueCommentBlockViewModel.ThumbsUpCount++,
                    ReactionContent.ThumbsDown => issueCommentBlockViewModel.ThumbsDownCount++,
                    ReactionContent.Laugh => issueCommentBlockViewModel.LaughCount++,
                    ReactionContent.Hooray => issueCommentBlockViewModel.HoorayCount++,
                    ReactionContent.Confused => issueCommentBlockViewModel.ConfusedCount++,
                    ReactionContent.Heart => issueCommentBlockViewModel.HeartCount++,
                    ReactionContent.Rocket => issueCommentBlockViewModel.RocketCount++,
                    ReactionContent.Eyes => issueCommentBlockViewModel.EyesCount++,
                };
            }

            return issueCommentBlockViewModel;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
            => throw new NotImplementedException();
    }
}
