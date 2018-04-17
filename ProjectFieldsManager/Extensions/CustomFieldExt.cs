using Microsoft.ProjectServer.Client;
using ProjectFieldsManager.Classes;
using ProjectFieldsManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Extensions
{
    public static class CustomFieldExt
    {
        public static ExportEnterpriseField GetExportField(this CustomField cf, PSContext ctx)
        {
            return new ExportEnterpriseField()
            {
                Id = cf.Id,
                Name = cf.Name,
                Description = cf.Description,
                EntityType = cf.EntityType.GetExportType(ctx),
                FieldType = cf.FieldType,
                Formula = cf.Formula,
                IsEditableInVisibility = cf.IsEditableInVisibility,
                IsMultilineText = cf.IsMultilineText,
                IsRequired = cf.IsRequired,
                IsWorkflowControlled = cf.IsWorkflowControlled,
                LookupAllowMultiSelect = cf.LookupAllowMultiSelect,
                LookupDefaultValue = cf.LookupDefaultValue,
                LookupTable = (bool)cf.LookupTable.ServerObjectIsNull ? null : cf.LookupTable?.Id
            };
        }
    }
}
