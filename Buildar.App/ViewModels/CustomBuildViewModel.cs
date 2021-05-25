using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Buildar.App.DataAccess;
using Buildar.App.Helpers;
using Buildar.Model;
using Buildar.Model.Parts;
using Microsoft.Data.SqlClient;

namespace Buildar.App.ViewModels
{
    public class CustomBuildViewModel : Observable
    {

        private ObservableCollection<Parts> parts = new ObservableCollection<Parts>();
        public ObservableCollection<Parts> Parts { get { return this.parts; } }

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


        public CustomBuildViewModel()
        {
            
            this.parts.Add(new Parts() { Part = "CPU", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/cpu.jpg" });
            this.parts.Add(new Parts() { Part = "GPU", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/gpu.jpg" });
            this.parts.Add(new Parts() { Part = "MEMORY", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/memory.jpg" });
            this.parts.Add(new Parts() { Part = "MOTHERBOARD", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/motherboard.jpg" });
            this.parts.Add(new Parts() { Part = "STORAGE", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/ssd.jpg" });
            this.parts.Add(new Parts() { Part = "POWERSUPPLY", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/psu2.jpg" });
            this.parts.Add(new Parts() { Part = "CASE", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/case.jpg" });
            this.parts.Add(new Parts() { Part = "COOLER",  PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/cooler.jpg" });
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

    public class Parts
    {
        public string Part { get; set; }
        public string PartImage { get; set; }
    }
}
