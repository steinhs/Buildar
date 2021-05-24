using Buildar.Model.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model
{
    public class Build
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Cpu CpuId { get; set; }

        public Gpu GpuId { get; set; }

        public Memory MemoryId { get; set; }

        public Storage StorageId { get; set; }
        //TODO Many storage

        public Psu PsuId { get; set; }

        // URL FOR IMAGE
        public string ImgURL { get; set; }

        // Foreign key to user. One build can have one user.
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
