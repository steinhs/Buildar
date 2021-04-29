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
}
