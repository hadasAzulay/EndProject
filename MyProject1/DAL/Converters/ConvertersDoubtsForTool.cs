using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
   public class ConvertersDoubtsForTool
    {
        public static EntitiesDoubtsForTool fromTblToEntity(DoubtsForTool d)
        {
            return new EntitiesDoubtsForTool()
            {
               DoubtsForTools=d.DoubtsForTools,
               DoubtId=d.DoubtId,
               ToolId=d.ToolId
             };
    }

        public static DoubtsForTool fromEntityToTbl(EntitiesDoubtsForTool d)
        {
            return new DoubtsForTool()
            {
                DoubtsForTools=d.DoubtsForTools,
               DoubtId=d.DoubtId,
               ToolId=d.ToolId
            };
        }
        public static List<DoubtsForTool> LfromEntityToTbl(List<EntitiesDoubtsForTool> ld)
        {
            List<DoubtsForTool> l = new List<DoubtsForTool>();
            foreach (var item in ld)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesDoubtsForTool> LfromTblToEntity(List<DoubtsForTool> ld)
        {
            List<EntitiesDoubtsForTool> l = new List<EntitiesDoubtsForTool>();
            foreach (var item in ld)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }

    }
}
