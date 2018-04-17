using Microsoft.ProjectServer.Client;
using ProjectFieldsManager.Classes;
using ProjectFieldsManager.Enums;
using ProjectFieldsManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFieldsManager.Extensions
{
    public static class EntityTypeExt
    {
        public static TypeOfEntity GetExportType(this EntityType type, PSContext ctx)
        {
            if(ctx.EntityTypes.ProjectEntity.Name == type.Name)
            {
                return TypeOfEntity.Project;
            }
            else if (ctx.EntityTypes.TaskEntity.Name == type.Name)
            {
                return TypeOfEntity.Task;
            }
            else if (ctx.EntityTypes.ResourceEntity.Name == type.Name)
            {
                return TypeOfEntity.Resource;
            }

            return TypeOfEntity.Undefined;
        }
    }
}
