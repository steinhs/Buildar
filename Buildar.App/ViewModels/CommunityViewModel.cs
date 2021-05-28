using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Buildar.App.DataAccess;
using Buildar.App.Helpers;
using Buildar.Model;
using Buildar.Model.Parts;
using Windows.UI.Xaml.Controls;

namespace Buildar.App.ViewModels
{
    public class CommunityViewModel : Observable
    {
        public ObservableCollection<Build> Builds { get; set; } = new ObservableCollection<Build>();
        public readonly Builds buildsDataAccess = new Builds();
        public ObservableCollection<Cpu> Cpus { get; set; } = new ObservableCollection<Cpu>();
        public readonly Cpus cpusDataAccess = new Cpus();
        public ObservableCollection<Gpu> Gpus { get; set; } = new ObservableCollection<Gpu>();
        public readonly Gpus gpusDataAccess = new Gpus();
        public ObservableCollection<Case> Cases { get; set; } = new ObservableCollection<Case>();
        public readonly Cases casesDataAccess = new Cases();
        public ObservableCollection<Cooler> Coolers { get; set; } = new ObservableCollection<Cooler>();
        public readonly Coolers coolersDataAccess = new Coolers();
        public ObservableCollection<Memory> Memorys { get; set; } = new ObservableCollection<Memory>();
        public readonly Memorys memorysDataAccess = new Memorys();
        public ObservableCollection<Psu> Psus { get; set; } = new ObservableCollection<Psu>();
        public readonly Psus psusDataAccess = new Psus();
        public ObservableCollection<Motherboard> Motherboards { get; set; } = new ObservableCollection<Motherboard>();
        public readonly Motherboards motherboardsDataAccess = new Motherboards();
        public ObservableCollection<Storage> Storages { get; set; } = new ObservableCollection<Storage>();
        public readonly Storages storagesDataAccess = new Storages();

        public Build selBuild;
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        public CommunityViewModel()
        {
            UpdateCommand = new RelayCommand<Build>(async param=>
            {

                if (selBuild != null)
                {
                    string newBuildName = await InputTextDialogAsync("Enter new build name");
                    if (newBuildName != "")
                    {
                        //await buildsDataAccess.UpdateBuildAsync((Build)param);
                        selBuild = null;
                    }
                    else { }
                    
                }
            }, param => param != null);


            DeleteCommand = new RelayCommand<Build>(async param =>
            {
                if (selBuild != null)
                {
                    //deleteFileDialog from https://docs.microsoft.com/en-us/windows/uwp/design/controls-and-patterns/dialogs-and-flyouts/dialogs
                    ContentDialog deleteFileDialog = new ContentDialog
                    {
                        Title = "Delete file permanently?",
                        Content = "If you delete this file, you won't be able to recover it. Do you want to delete it?",
                        PrimaryButtonText = "Delete",
                        CloseButtonText = "Cancel"
                    };

                    ContentDialogResult result = await deleteFileDialog.ShowAsync();

                    // Delete the file if the user clicked the primary button.
                    /// Otherwise, do nothing.
                    if (result == ContentDialogResult.Primary)
                    {
                        await buildsDataAccess.DeleteBuildAsync((Build)param);
                        Builds.Remove(param);
                    }
                    else
                    {
                    }
                    selBuild = null;
                }
            }, param => param != null);
        }

        private async Task<string> InputTextDialogAsync(string newName)
        {
            TextBox input = new TextBox();
            input.AcceptsReturn = false;
            input.Height = 32;
            ContentDialog dialog = new ContentDialog();
            dialog.Content = input;
            dialog.Title = newName;
            dialog.IsSecondaryButtonEnabled = true;
            dialog.PrimaryButtonText = "Ok";
            dialog.SecondaryButtonText = "Cancel";
            if (await dialog.ShowAsync() == ContentDialogResult.Primary)
                return input.Text;
            else
                return "";
        }

        

        internal async Task LoadBuildsAsync()
        {
            var builds = await buildsDataAccess.GetBuildsAsync();

            foreach (Build build in builds)
                Builds.Add(build);
        }
        internal async Task LoadCpusAsync()
        {
            var cpus = await cpusDataAccess.GetCpusAsync();

            foreach (Cpu cpu in cpus)
                Cpus.Add(cpu);
        }
        internal async Task LoadGpusAsync()
        {
            var gpus = await gpusDataAccess.GetGpusAsync();

            foreach (Gpu gpu in gpus)
                Gpus.Add(gpu);
        }
        internal async Task LoadCasesAsync()
        {
            var cases = await casesDataAccess.GetCasesAsync();

            foreach (Case casee in cases)
                Cases.Add(casee);
        }
        internal async Task LoadCoolersAsync()
        {
            var coolers = await coolersDataAccess.GetCoolersAsync();

            foreach (Cooler cooler in coolers)
                Coolers.Add(cooler);
        }
        internal async Task LoadMemorysAsync()
        {
            var memorys = await memorysDataAccess.GetMemorysAsync();

            foreach (Memory memory in memorys)
                Memorys.Add(memory);
        }
        internal async Task LoadPsusAsync()
        {
            var psus = await psusDataAccess.GetPsusAsync();

            foreach (Psu e in psus)
                Psus.Add(e);
        }
        internal async Task LoadMotherboardsAsync()
        {
            var motherboards = await motherboardsDataAccess.GetMotherboardsAsync();

            foreach (Motherboard e in motherboards)
                Motherboards.Add(e);
        }
        internal async Task LoadStoragesAsync()
        {
            var storages = await storagesDataAccess.GetStoragesAsync();

            foreach (Storage e in storages)
                Storages.Add(e);
        }
        
    }
}
