using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Buildar.App.Views
{
    public sealed partial class MyBuildsPage : Page
    {
        public MyBuildsViewModel ViewModel { get; } = new MyBuildsViewModel();

        public MyBuildsPage()
        {
            InitializeComponent();
        }
    }
}
