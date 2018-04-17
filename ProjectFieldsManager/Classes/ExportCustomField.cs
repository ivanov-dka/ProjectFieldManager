using Microsoft.ProjectServer.Client;
using ProjectFieldsManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Classes
{    
    public class ExportEnterpriseField
    {
        public bool IsExported { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeOfEntity EntityType { get; set; }
        public CustomFieldType FieldType { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Formula { get; set; }

        [System.ComponentModel.Browsable(false)]
        public bool IsEditableInVisibility { get; set; }

        [System.ComponentModel.Browsable(false)]
        public bool IsMultilineText { get; set; }

        [System.ComponentModel.Browsable(false)]
        public bool IsRequired { get; set; }

        [System.ComponentModel.Browsable(false)]
        public bool IsWorkflowControlled { get; set; }

        [System.ComponentModel.Browsable(false)]
        public bool LookupAllowMultiSelect { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Guid? LookupDefaultValue { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Guid? LookupTable { get; set; }
    }
}
