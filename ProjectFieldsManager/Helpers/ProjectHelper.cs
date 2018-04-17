using Microsoft.SharePoint.Client;
using ProjectFieldsManager.Classes;
using ProjectFieldsManager.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Helpers
{
    public static class ProjectHelper
    {
        public static ExportEntity GetCustomEntities()
        {
            ExportEntity result = new ExportEntity();

            using (var ctx = new PSContext())
            {
                ctx.Load(ctx.EntityTypes.ProjectEntity);
                ctx.Load(ctx.EntityTypes.TaskEntity);
                ctx.Load(ctx.EntityTypes.ResourceEntity);
                ctx.ExecuteQuery();

                var customFieldNames = ctx.LoadQuery(ctx.CustomFields.IncludeWithDefaultProperties(
                        f => f.InternalName,
                        f => f.Id,
                        f => f.Name,
                        f => f.Description,
                        f => f.EntityType,
                        f => f.FieldType,
                        f => f.Formula,
                        f => f.IsMultilineText,
                        f => f.IsEditableInVisibility,
                        f => f.IsRequired,
                        f => f.IsWorkflowControlled,
                        f => f.LookupAllowMultiSelect,
                        f => f.LookupDefaultValue,
                        f => f.LookupTable));
                ctx.ExecuteQuery();

                result.Fields = customFieldNames.Select(cf => cf.GetExportField(ctx)).ToList();

                var lookupTables = ctx.LoadQuery(ctx.LookupTables.IncludeWithDefaultProperties(
                    f => f.Id,
                    f => f.Name,
                    f => f.Masks,
                    f => f.FieldType,
                    f => f.Entries,
                    f => f.SortOrder));
                ctx.ExecuteQuery();

                result.Tables = lookupTables.Select(t => t.GetExportTable(ctx)).ToList();

                return result;
            }
        }
    }
}
