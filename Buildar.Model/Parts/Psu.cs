using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Psu
    {
        public string PsuId { get; set; }

        public string PsuModel { get; set; }

        public string PsuMaker { get; set; }

        public int PsuPrice { get; set; }

        public int PsuWattage { get; set; }

        public string PsuCertification { get; set; }
    }
}
