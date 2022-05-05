using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersToolsForDay
    {
        public static EntitiesToolsForDay fromTblToEntity(ToolsForDay t)
        {
            return new EntitiesToolsForDay()
            {
              ToolsForDay1=t.ToolsForDay1,
              ToolId=t.ToolId,
              Amount=t.Amount,
              DailyDiary=t.DailyDiary
            };
        }
        public static ToolsForDay fromEntityToTbl(EntitiesToolsForDay t)
        {
            return new ToolsForDay()
            {

                ToolsForDay1 = t.ToolsForDay1,
                ToolId = t.ToolId,
                Amount = t.Amount,
                DailyDiary = t.DailyDiary
            };
        }
        public static List<ToolsForDay> LfromEntityToTbl(List<EntitiesToolsForDay> lt)
        {
            List<ToolsForDay> l = new List<ToolsForDay>();
            foreach (var item in lt)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesToolsForDay> LfromTblToEntity(List<ToolsForDay> lt)
        {
            List<EntitiesToolsForDay> l = new List<EntitiesToolsForDay>();
            foreach (var item in lt)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
