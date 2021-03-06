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
using Windows.UI.Popups;
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
                try
                {
                    var build = new Build()
                    {
                        BuildName = buildName,
                        CpuId = cpuSelected.Id,
                        GpuId = gpuSelected.Id,
                        PsuId = psuSelected.Id,
                        CaseId = caseSelected.Id,
                        CoolerId = coolerSelected.Id,
                        StorageId = storageSelected.Id,
                        MotherboardId = motherboardSelected.Id,
                        MemoryId = memorySelected.Id,
                        UserId = 1,
                        //#TODO TEMP IMGURL
                        ImgURL = "https://www.computerrepairsspringfield.com.au/wp-content/uploads/2017/04/custom-computer-build.jpg"//#TODO TEMP **************************,
                    };
                    if (await ViewModel.buildsDataAccess.AddBuildAsync(build))
                        ViewModel.Builds.Add(build);

                    await new MessageDialog(buildName + " was created. Check it out in Community builds section!", "Success!").ShowAsync();

                }
                catch (System.NullReferenceException ex)
                {
                    Console.WriteLine("Input missing: " + ex);
                    await new MessageDialog("Missing input. Check that all boxes have parts in them!", "Missing input").ShowAsync();
                    return;
                }
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
