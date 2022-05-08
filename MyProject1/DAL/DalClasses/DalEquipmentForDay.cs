using DAL.Converters;
using DAL.DaliClasses;
using DAL.models;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DalClasses
{
 public   class DalEquipmentForDay: IDalEquipmentForDay
    {
        finalProject1Context db;
        public DalEquipmentForDay(finalProject1Context db)
        {
            this.db = db;
        }
        public List<EntitiesEquipmentForDay> getAll()
        {
            return ConvertersEquipmentForDay.LfromTblToEntity(db.EquipmentForDays.ToList());
        }
        public List<EntitiesEquipmentForDay> putEquipmentForDay(EntitiesEquipmentForDay e)
        {
            db.EquipmentForDays.Add(ConvertersEquipmentForDay.fromEntityToTbl(e));
            db.SaveChanges();
            return getAll();
        }
     
    }
}
