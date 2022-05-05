using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersTool
    {
        public static EntitiesTool fromTblToEntity(Tool t)
        {
            return new EntitiesTool()
            {
               ToolId=t.ToolId,
               ToolName=t.ToolName
            };
        }
        public static Tool fromEntityToTbl(EntitiesTool t)
        {
            return new Tool()
            {
                ToolId = t.ToolId,
                ToolName = t.ToolName
            };
        }
        public static List<Tool> LfromEntityToTbl(List<EntitiesTool> lt)
        {
            List<Tool> l = new List<Tool>();
            foreach (var item in lt)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesTool> LfromTblToEntity(List<Tool> lt)
        {
            List<EntitiesTool> l = new List<EntitiesTool>();
            foreach (var item in lt)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
