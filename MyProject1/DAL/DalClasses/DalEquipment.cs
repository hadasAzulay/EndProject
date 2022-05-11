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
   public class DalEquipment: IDalEquipment
    {
        finalProject1Context db;
        public DalEquipment(finalProject1Context DB)
        {
            db = DB;
        }
        //Add
        public List<EntitiesEquipment> PutEquipment(EntitiesEquipment t)
        {
            db.Equipment.Add(ConvertersEquipment.fromEntityToTbl(t));
            db.SaveChanges();
            return getAll();
        }
        //delete

        public List<EntitiesEquipment> DeleteEquipment(EntitiesEquipment t)
        {
            db.Equipment.Remove(ConvertersEquipment.fromEntityToTbl(t));
            db.SaveChanges();
            return getAll();
        }
        //getAll

        public List<EntitiesEquipment> getAll()
        {
            return ConvertersEquipment.LfromTblToEntity(db.Equipment.ToList());
        }
    }

}

