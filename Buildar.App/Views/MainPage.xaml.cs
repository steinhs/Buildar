using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Buildar.App.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        private void GridViewContent_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {

                case "Build Your Own Computer":
                    this.Frame.Navigate(typeof(CustomBuildPage));
                    break;

                case "High End":
                    this.Frame.Navigate(typeof(HighEndPage));
                    break;

                case "Mid Range":
                    this.Frame.Navigate(typeof(MidRangePage));
                    break;

                case "Budget Build":
                    this.Frame.Navigate(typeof(BudgetPage));
                    break;

                case "Community":
                    this.Frame.Navigate(typeof(CommunityPage));
                    break;
                case "My Builds":
                    this.Frame.Navigate(typeof(MyBuildsPage));
                    break;
            }

        }
        private async void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await ViewModel.LoadBuildsAsync();
        }
    }
}
