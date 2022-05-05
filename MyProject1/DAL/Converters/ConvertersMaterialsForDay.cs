using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersMaterialsForDay
    {
        public static EntitiesMaterialsForDay fromTblToEntity(MaterialsForDay m)
        {
            return new EntitiesMaterialsForDay()
            {
               MaterialsForDay1=m.MaterialsForDay1,
               DailyDiary=m.DailyDiary,
               MaterialsId=m.MaterialsId,
               Amount=m.Amount
            };
        }
        public static MaterialsForDay fromEntityToTbl(EntitiesMaterialsForDay m)
        {
            return new MaterialsForDay()
            {
                MaterialsForDay1 = m.MaterialsForDay1,
                DailyDiary = m.DailyDiary,
                MaterialsId = m.MaterialsId,
                Amount = m.Amount
            };
        }
        public static List<MaterialsForDay> LfromEntityToTbl(List<EntitiesMaterialsForDay> lm)
        {
            List<MaterialsForDay> l = new List<MaterialsForDay>();
            foreach (var item in lm)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesMaterialsForDay> LfromTblToEntity(List<MaterialsForDay> lm)
        {
            List<EntitiesMaterialsForDay> l = new List<EntitiesMaterialsForDay>();
            foreach (var item in lm)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
