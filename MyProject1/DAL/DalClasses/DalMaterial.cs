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
  public  class DalMaterial:IDalMaterial
    {
        finalProject1Context db;
        public DalMaterial(finalProject1Context db)
        {
            this.db = db;
        }
        public List<EntitiesMaterial> getAll()
        {
            return ConvertersMaterial.LfromTblToEntity(db.Materials.ToList());
        }
        //Add

        public List<EntitiesMaterial> PutMaterial(EntitiesMaterial m)
        {
            db.Materials.Add(ConvertersMaterial.fromEntityToTbl(m));
            db.SaveChanges();
            return getAll();
        }
        //delete

        public List<EntitiesMaterial> deleteMaterial(EntitiesMaterial m)
        {
            db.Materials.Remove(ConvertersMaterial.fromEntityToTbl(m));
            db.SaveChanges();
            return getAll();
        }
    }
}
