using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildar.App.ViewModels
{
    public class BuildPart
    {
        public string Part { get; set; }
        public string PartImage { get; set; }
        public string PartNameSum
        {
            get
            {
                return $"{this.Part}";
            }
        }
        public string PartImageUrl
        {
            get
            {
                return $"{this.PartImage}";
            }
        }
    }
}
