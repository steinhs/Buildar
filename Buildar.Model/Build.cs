using Buildar.Model.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model
{
    public class Build
    {
        public int Id { get; set; }

        public string BuildName { get; set; }

        public int CpuId { get; set; }
        public Cpu Cpu { get; set; }

        public int GpuId { get; set; }
        public Gpu Gpu { get; set; }

        public int MotherboardId { get; set; }
        public Motherboard Motherboard { get; set; }

        public int MemoryId { get; set; }
        public Memory Memory { get; set; }

        public int StorageId { get; set; }
        public Storage Storage { get; set; }
        //TODO Many storage

        public int PsuId { get; set; }
        public Psu Psu { get; set; }

        public int CaseId { get; set; }
        public Case Case { get; set; }

        public int CoolerId { get; set; }
        public Cooler Cooler { get; set; }

        // URL FOR IMAGE
        public string ImgURL { get; set; }

        // Foreign key to user. One build can have one user.
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
