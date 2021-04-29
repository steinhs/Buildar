using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Storage
    {
        public string StorageId { get; set; }

        public string StorageModel { get; set; }

        public string StorageMaker { get; set; }

        public int StoragePrice { get; set; }

        public int StorageSize { get; set; }

        public string StorageType { get; set; }
        public int StorageEstWattage { get; set; }
    }
}
