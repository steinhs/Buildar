using Buildar.Model.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buildar.Model
{
    public class Build
    {
        public string BuildId { get; set; }

        public string BuildName { get; set; }

        public Cpu Cpu { get; set; }

        public Gpu Gpu { get; set; }

        public Memory Memory { get; set; }

        public Storage Storage { get; set; }
        //TODO Have list of storage

        public Psu Psu { get; set; }

        // URL FOR IMAGE
        public string MainImage { get; set; }

        // Foreign key to user. One build can have one user.
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
