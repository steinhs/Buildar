using System;
using Buildar.Model;
using Buildar.Model.Parts;
using Buildar.App.Helpers;
using System.Collections.ObjectModel;

namespace Buildar.App.ViewModels
{
    public class HighEndViewModel : Observable
    {
        private ObservableCollection<BuildTemp> buildTemps = new ObservableCollection<BuildTemp>();
        public ObservableCollection<BuildTemp> BuildTemps { get { return this.buildTemps; } }
        public HighEndViewModel()
        {
            this.buildTemps.Add(new BuildTemp() { BuildName = "Extreme Cashgrabber", Cpu = "Ryzen 9 5990X", Gpu = "RTX 3090", ImageUrl = "https://itstud.hiof.no/~steinhs/subjects/netImgs/bud1.jpg"});
            this.buildTemps.Add(new BuildTemp() { BuildName = "Smol but hard hitting", Cpu = "Ryzen 5 5600", Gpu = "RTX 3080", ImageUrl = "https://itstud.hiof.no/~steinhs/subjects/netImgs/bud2.jpg" });
            this.buildTemps.Add(new BuildTemp() { BuildName = "Extreme Cashgrabber", Cpu = "Ryzen 7 3700", Gpu = "RTX 3070", ImageUrl = "https://itstud.hiof.no/~steinhs/subjects/netImgs/bud3.jpg" });
        }
    }

    public class BuildTemp
    {
        public string BuildName { get; set; }
        public string Cpu { get; set; }
        public string Gpu { get; set; }

        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Buildname
        {
            get
            {
                return $"{this.BuildName}";
            }
        }

        public string BuildInfo
        {
            get
            {
                return $"{this.Cpu} & {this.Gpu}";
            }
        }

        public string BuildPrice
        {
            get
            {
                return $"{this.Price}";
            }
        }

        public string FullImageUrl
        {
            get
            {
                return $"{this.ImageUrl}";
            }
        }
    }

    public class BuildPart
    {
        public string Part { get; set; }
        public string PartImage { get; set; }
        public string PartNameSum
        {
            get
            {
                return $"{this.Part}";
            }
        }
        public string PartImageUrl
        {
            get
            {
                return $"{this.PartImage}";
            }
        }
    }
}
