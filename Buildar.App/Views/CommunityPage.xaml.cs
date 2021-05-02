using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Buildar.App.Views
{
    public sealed partial class CommunityPage : Page
    {
        public CommunityViewModel ViewModel { get; } = new CommunityViewModel();

        public CommunityPage()
        {
            InitializeComponent();
        }
    }
}
