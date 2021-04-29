using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Buildar.App.DataAccess;
using Buildar.App.Helpers;
using Buildar.Model;
using Buildar.Model.Parts;

namespace Buildar.App.ViewModels
{
    public class CustomBuildViewModel : Observable
    {

        private ObservableCollection<BuildPart> buildparts = new ObservableCollection<BuildPart>();
        public ObservableCollection<BuildPart> Buildparts { get { return this.buildparts; } }
        public CustomBuildViewModel()
        {
            this.buildparts.Add(new BuildPart() { Part = "CPU", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/cpu.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "GPU", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/gpu.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "MEMORY", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/memory.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "MOTHERBOARD", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/motherboard.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "STORAGE", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/ssd.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "POWERSUPPLY", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/psu2.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "CASE", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/case.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "COOLER",  PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/cooler.jpg" });
        }
    }
}
