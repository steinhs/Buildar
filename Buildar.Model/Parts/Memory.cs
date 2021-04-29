using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Memory
    {
        public string MemoryId { get; set; }

        public string MemoryModel { get; set; }

        public string MemoryMaker { get; set; }

        public int RMemorySticks { get; set; }

        public int MemoryPrice { get; set; }

        public string MemoryType { get; set; }

        public int MemorySpeed { get; set; }
        public int MemoryEstWattage { get; set; }
    }
}
