using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildar.App.ViewModels
{
    public class BuildTemp
    {
        public string BuildName { get; set; }
        public string Cpu { get; set; }
        public string Gpu { get; set; }

        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Buildname
        {
            get
            {
                return $"{this.BuildName}";
            }
        }

        public string BuildInfo
        {
            get
            {
                return $"{this.Cpu} & {this.Gpu}";
            }
        }

        public string BuildPrice
        {
            get
            {
                return $"{this.Price}";
            }
        }

        public string FullImageUrl
        {
            get
            {
                return $"{this.ImageUrl}";
            }
        }
    }
}
