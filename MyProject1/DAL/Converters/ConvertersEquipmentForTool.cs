using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersEquipmentForTool
    {
        public static EntitiesEquipmentForTool fromTblToEntity(EquipmentForTool e)
        {
            return new EntitiesEquipmentForTool()
            {
               EquipmentForTools=e.EquipmentForTools,
               EquipmentId=e.EquipmentId,
               DoubtId=e.DoubtId
            };
        }
        public static EquipmentForTool fromEntityToTbl(EntitiesEquipmentForTool e)
        {
            return new EquipmentForTool()
            {
                EquipmentForTools = e.EquipmentForTools,
                EquipmentId = e.EquipmentId,
                DoubtId = e.DoubtId
            };
        }
        public static List<EquipmentForTool> LfromEntityToTbl(List<EntitiesEquipmentForTool> le)
        {
            List<EquipmentForTool> l = new List<EquipmentForTool>();
            foreach (var item in le)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesEquipmentForTool> LfromTblToEntity(List<EquipmentForTool> le)
        {
            List<EntitiesEquipmentForTool> l = new List<EntitiesEquipmentForTool>();
            foreach (var item in le)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
