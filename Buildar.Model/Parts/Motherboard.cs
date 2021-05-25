using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Motherboard
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Maker { get; set; }

        public int Price { get; set; }

        public string Socket { get; set; }

        public string Chipset { get; set; }

        public int EstWatt { get; set; }
        public string ImgURL { get; set; }
    }
}
