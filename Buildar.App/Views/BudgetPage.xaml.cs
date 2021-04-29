using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Buildar.App.Views
{
    public sealed partial class BudgetPage : Page
    {
        public BudgetViewModel ViewModel { get; } = new BudgetViewModel();

        public BudgetPage()
        {
            InitializeComponent();
        }
    }
}
