using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Buildar.App.DataAccess;
using Buildar.App.Helpers;
using Buildar.App.ViewModels;
using Buildar.Model;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using System.Linq;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml;

namespace Buildar.App.Views
{
    public sealed partial class CommunityPage : Page
    {
        public CommunityViewModel ViewModel { get; } = new CommunityViewModel();

        public CommunityPage()
        {
            InitializeComponent();
        }
  

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.selBuild = (Build)e.ClickedItem;
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
