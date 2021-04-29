using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Motherboard
    {
        public string MotherboardId { get; set; }

        public string MotherboardModel { get; set; }

        public string MotherboardMaker { get; set; }

        public int MotherboardPrice { get; set; }

        public string MotherboardSocket { get; set; }

        public string MotherboardChipset { get; set; }

        public string MotherboardMaxSize { get; set; }
        public int MotherboardEstWattage { get; set; }
    }
}
