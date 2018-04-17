using Microsoft.ProjectServer.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Classes
{
    public class ExportLookupMask
    {
        public int Length { get; set; }
        public LookupTableMaskSequence MaskType { get; set; }
        public string Separator { get; set; }
    }
}
