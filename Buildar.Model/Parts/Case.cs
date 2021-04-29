using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Buildar.Model.Parts
{
    public class Case
    {
        public string CaseId { get; set; }

        public string CaseModel { get; set; }

        public string CaseMaker { get; set; }

        public int CasePrice { get; set; }

        public int CaseSize { get; set; }
        //Case sizes: ITX-1, ATX-2
    }
}
