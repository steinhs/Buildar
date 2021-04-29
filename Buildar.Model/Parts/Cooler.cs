using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Cooler
    {
        public string CoolerId { get; set; }

        public string CoolerModel { get; set; }

        public string CoolerMaker { get; set; }

        public int CoolerPrice { get; set; }

        public int CoolerNoiseMin { get; set; }

        public int CoolerNoiseMax { get; set; }

        public int CoolerRpmMin { get; set; }

        public int CoolerRpmMax { get; set; }

        public int CoolerEstWattage { get; set; }
    }
}
