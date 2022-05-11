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
  public  class DalMaterialsForDay: IDalMaterialsForDay
    {

        finalProject1Context db;
        public DalMaterialsForDay(finalProject1Context DB)
        {
            db = DB;
        }
        //Add
        public List<EntitiesMaterialsForDay> PutMaterialsForDay(EntitiesMaterialsForDay m)
        {
            db.MaterialsForDays.Add(ConvertersMaterialsForDay.fromEntityToTbl(m));
            db.SaveChanges();
            return getAll();
        }
        //delete
        public List<EntitiesMaterialsForDay> deleteMaterialsForDay(EntitiesMaterialsForDay m)
        {
            db.MaterialsForDays.Remove(ConvertersMaterialsForDay.fromEntityToTbl(m));
            db.SaveChanges();
            return getAll();
        }


        //getAll

        public List<EntitiesMaterialsForDay> getAll()
        {
            return ConvertersMaterialsForDay.LfromTblToEntity(db.MaterialsForDays.ToList());
        }
    }

}

