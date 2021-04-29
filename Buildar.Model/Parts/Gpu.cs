using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Gpu
    {
        public string GpuId { get; set; }

        public string GpuModel { get; set; }

        public string GpuMaker { get; set; }

        public int GpuPrice { get; set; }

        public int GpuVram { get; set; }

        public int GpuClock { get; set; }

        public int GpuReleaseDate { get; set; }
        public int GpuEstWattage { get; set; }
    }
}
