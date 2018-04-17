using Microsoft.ProjectServer.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Classes
{
    public class ExportLookupTable
    {
        public bool IsExported { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CustomFieldType FieldType { get; set; }

        [System.ComponentModel.Browsable(false)]
        public LookupTableSortOrder SortOrder { get; set; }

        [System.ComponentModel.Browsable(false)]
        public List<ExportLookupText> Entries { get; set; }

        [System.ComponentModel.Browsable(false)]
        public List<ExportLookupMask> Masks { get; set; }
    }
}
