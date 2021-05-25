using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Case
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Maker { get; set; }

        public int Price { get; set; }

        public string ImgURL { get; set; }

        public string FullName => $"{Maker} {Model}";

        public string CriticalInformation => $"{Maker} {Model}  ({Price},-)";

        public string Parttype => $"Case";
    }
}
