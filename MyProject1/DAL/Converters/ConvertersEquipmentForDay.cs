using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    public class ConvertersEquipmentForDay
    {
        public static EntitiesEquipmentForDay fromTblToEntity(EquipmentForDay e)
        {
            return new EntitiesEquipmentForDay()
            {
               EquipmentForDay1=e.EquipmentForDay1,
               EquipmentId=e.EquipmentId,
               DailyDiary=e.DailyDiary,
               Amount=e.Amount
            };
        }
        public static EquipmentForDay fromEntityToTbl(EntitiesEquipmentForDay e)
        {
            return new EquipmentForDay()
            {
                EquipmentForDay1 = e.EquipmentForDay1,
                EquipmentId = e.EquipmentId,
                DailyDiary = e.DailyDiary,
                Amount = e.Amount
            };
        }
        public static List<EquipmentForDay> LfromEntityToTbl(List<EntitiesEquipmentForDay> le)
        {
            List<EquipmentForDay> l = new List<EquipmentForDay>();
            foreach (var item in le)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesEquipmentForDay> LfromTblToEntity(List<EquipmentForDay> le)
        {
            List<EntitiesEquipmentForDay> l = new List<EntitiesEquipmentForDay>();
            foreach (var item in le)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
