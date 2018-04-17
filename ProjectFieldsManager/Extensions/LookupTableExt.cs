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
    public static class LookupTableExt
    {
        public static ExportLookupTable GetExportTable(this LookupTable t, PSContext ctx)
        {
            return new ExportLookupTable()
            {
                Id = t.Id,
                Name = t.Name,
                Entries = t.Entries.Select(e => new ExportLookupText()
                {
                    FullValue = e.FullValue,
                    Id = e.Id                    
                }).ToList(),
                FieldType = t.FieldType,
                Masks = t.Masks.Select(m => new ExportLookupMask()
                {
                    MaskType = m.MaskType,
                    Length = m.Length,
                    Separator = m.Separator

                }).ToList(),
                SortOrder = t.SortOrder
            };
        }
    }
}
