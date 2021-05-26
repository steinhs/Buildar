using System;
using System.Collections.ObjectModel;
using Buildar.App.DataAccess;
using Buildar.App.ViewModels;
using Buildar.Model;
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
        private async void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await ViewModel.LoadBuildsAsync();
            await ViewModel.LoadCpusAsync();
            await ViewModel.LoadGpusAsync();
            await ViewModel.LoadCasesAsync();
            await ViewModel.LoadCoolersAsync();
            await ViewModel.LoadStoragesAsync();
            await ViewModel.LoadMemorysAsync();
            await ViewModel.LoadMotherboardsAsync();
            await ViewModel.LoadPsusAsync();
        }
    }
}
