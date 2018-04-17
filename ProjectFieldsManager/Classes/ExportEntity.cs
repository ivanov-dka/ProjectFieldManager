using Microsoft.ProjectServer.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Classes
{
    public class ExportEntity
    {
        public List<ExportEnterpriseField> Fields { get; set; }
        public List<ExportLookupTable> Tables { get; set; }
    }
}
