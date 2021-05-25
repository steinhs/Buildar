using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Gpu
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Maker { get; set; }

        public int Price { get; set; }

        public int EstWatt { get; set; }
        public string ImgURL { get; set; }

        public string FullName => $"{Maker} {Model}";
        public string CriticalInformation => $"{Maker} {Model}  ({Price},-)";
        public string Parttype => $"Graphics card";

    }
}
