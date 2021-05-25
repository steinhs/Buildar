using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Storage
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Maker { get; set; }

        public int Price { get; set; }

        public int Size { get; set; }

        public string Type { get; set; }

        public int EstWatt { get; set; }
        public string ImgURL { get; set; }
    }
}
