using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Buildar.App.Views
{
    public sealed partial class MidRangePage : Page
    {
        public MidRangeViewModel ViewModel { get; } = new MidRangeViewModel();

        public MidRangePage()
        {
            InitializeComponent();
        }
    }
}
