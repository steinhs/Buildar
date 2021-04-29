using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Buildar.App.Views
{
    public sealed partial class HighEndPage : Page
    {
        public HighEndViewModel ViewModel { get; } = new HighEndViewModel();

        public HighEndPage()
        {
            InitializeComponent();
        }
    }
}
