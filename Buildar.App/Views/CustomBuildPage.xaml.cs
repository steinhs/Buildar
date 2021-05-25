using Buildar.App.ViewModels;
using Buildar.Model.Parts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;
namespace Buildar.App.Views
{
    public sealed partial class CustomBuildPage : Page
    {
        //Gets methods and data from CustomBuildViewModel ViewModel
        public CustomBuildViewModel ViewModel { get; } = new CustomBuildViewModel();


        public CustomBuildPage()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            await ViewModel.LoadCpusAsync();
            await ViewModel.LoadGpusAsync();
            await ViewModel.LoadCasesAsync();
            await ViewModel.LoadCoolersAsync();
            await ViewModel.LoadStoragesAsync();
            //await ViewModel.LoadMemorysAsync();
            await ViewModel.LoadMotherboardsAsync();
            await ViewModel.LoadPsusAsync();
        }






        public class Parts
        {
            public string Part { get; set; }
            public override string ToString()
            {
                return Part;
            }
        }

    }
}
