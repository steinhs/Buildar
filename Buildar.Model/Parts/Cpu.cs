using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Cpu
    {
        public string CpuId { get; set; }

        public string CpuModel { get; set; }

        public string CpuMaker { get; set; }

        public int CpuPrice { get; set; }

        public int CpuCores { get; set; }

        public int CpuThreads { get; set; }

        public int CpuClockMin { get; set; }

        public int CpuClockMax { get; set; }

        public string CpuSocket { get; set; }

        public int CpuReleaseDate { get; set; }
        public int CpuEstWattage { get; set; }
    }
}
