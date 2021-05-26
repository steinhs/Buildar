using Buildar.App.DataAccess;
using Buildar.App.Helpers;
using Buildar.App.ViewModels;
using Buildar.Model;
using Buildar.Model.Parts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
namespace Buildar.App.Views
{
    public sealed partial class CustomBuildPage : Page
    {
        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }

        //Gets methods and data from CustomBuildViewModel ViewModel
        public CustomBuildViewModel ViewModel { get; } = new CustomBuildViewModel();


        public CustomBuildPage()
        {
            InitializeComponent();

            AddCommand = new RelayCommand<string>(async buildName =>
            {
                var build = new Build()
                {
                    BuildName = buildName,
                    CpuId = cpuSelected.Id,
                    GpuId = gpuSelected.Id,
                    PsuId = psuSelected.Id,
                    CaseId = psuSelected.Id,
                    CoolerId = coolerSelected.Id,
                    StorageId = storageSelected.Id,
                    MotherboardId = motherboardSelected.Id,
                    MemoryId = memorySelected.Id,
                    UserId = 1 //#TODO TEMP **************************
                };
                if (await ViewModel.buildsDataAccess.AddBuildAsync(build))
                    ViewModel.Builds.Add(build);
            });
        }

        private async void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            await ViewModel.LoadCpusAsync();
            await ViewModel.LoadGpusAsync();
            await ViewModel.LoadCasesAsync();
            await ViewModel.LoadCoolersAsync();
            await ViewModel.LoadStoragesAsync();
            await ViewModel.LoadMemorysAsync();
            await ViewModel.LoadMotherboardsAsync();
            await ViewModel.LoadPsusAsync();
        }

        //#TODO Might be removed
        public class Parts
        {
            public string Part { get; set; }
            public override string ToString()
            {
                return Part;
            }
        }

        private  Cpu cpuSelected;
        private  Gpu gpuSelected;
        private Psu psuSelected;
        private Case caseSelected;
        private Cooler coolerSelected;
        private Storage storageSelected;
        private Motherboard motherboardSelected;
        private Memory memorySelected;

        //#TODO SelectionChangeds can be made into one dynamic method
        private void cbCpu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            cpuSelected = ((Cpu)combo.SelectedItem);
        }
        private void cbGpu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            gpuSelected = ((Gpu)combo.SelectedItem);
        }
        private void cbPsu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            psuSelected = ((Psu)combo.SelectedItem);
        }
        private void cbCase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            caseSelected = ((Case)combo.SelectedItem);
        }
        private void cbCooler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            coolerSelected = ((Cooler)combo.SelectedItem);
        }
        private void cbStorage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            storageSelected = ((Storage)combo.SelectedItem);
        }
        private void cbMotherboard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            motherboardSelected = ((Motherboard)combo.SelectedItem);
        }
        private void cbMemory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            memorySelected = ((Memory)combo.SelectedItem);
        }
    }
}
