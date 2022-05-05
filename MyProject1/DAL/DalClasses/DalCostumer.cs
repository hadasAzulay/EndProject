using DAL.DaliClasses;
using DAL.models;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Converters;

namespace DAL.DalClasses

{

    public class DalCostumer : IDalCostumer

    {
        finalProject1Context db;
        public DalCostumer(finalProject1Context DB)
        {
            db = DB;
        }
       
        
        public List<EntitiesCostumer> getAll()
        {
            return ConvertersCostumer.LfromTblToEntity(db.Costumers.ToList());
        }
        public List<EntitiesCostumer> putCostumer(EntitiesCostumer c)
        {
            db.Costumers.Add(ConvertersCostumer.fromEntityToTbl(c));
            db.SaveChanges();
            return getAll();
        }
    } 
}