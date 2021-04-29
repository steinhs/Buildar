using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Buildar.App.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
