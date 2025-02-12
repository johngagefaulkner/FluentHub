using FluentHub.App.Models;
using FluentHub.App.Services;
using FluentHub.App.ViewModels.UserControls.FeedBlocks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace FluentHub.App.UserControls.FeedBlocks
{
    public sealed partial class ActivityBlock : UserControl
    {
        #region propdp
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(
               nameof(ViewModel),
               typeof(ActivityBlockViewModel),
               typeof(ActivityBlock),
               new PropertyMetadata(null));

        public ActivityBlockViewModel ViewModel
        {
            get => (ActivityBlockViewModel)GetValue(ViewModelProperty);
            set
            {
                SetValue(ViewModelProperty, value);
                ViewModel?.LoadContentsAsync();
            }
        }
        #endregion

        public ActivityBlock()
            => InitializeComponent();
    }
}
