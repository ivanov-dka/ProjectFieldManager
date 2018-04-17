using Microsoft.ProjectServer.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Helpers
{
    public class ProjectCustomFields
    {
        public static bool AddFields(PSContext ctx, List<CustomFieldCreationInformation> fields)
        {
            foreach(var f in fields)
            {               
                ctx.CustomFields.Add(f);
            }
            
            ctx.CustomFields.Update();
            ctx.ExecuteQuery();
            return true;
        }

        public static bool AddTables(PSContext ctx, List<LookupTableCreationInformation> tables)
        {
            foreach (var t in tables)
            {
                ctx.LookupTables.Add(t);
            }

            ctx.LookupTables.Update();
            ctx.ExecuteQuery();
            return true;
        }
    }
}
