using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Cpu
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Maker { get; set; }

        public int Price { get; set; }

        public int Cores { get; set; }

        public int Threads { get; set; }

        public string Socket { get; set; }

        public int EstWatt { get; set; }
    }
}
