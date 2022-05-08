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
   public class DalDailyDairy: IDalDailyDairy
    {
        finalProject1Context db;
        public DalDailyDairy(finalProject1Context db)
        {
            this.db = db;
        }
        public List<EntitiesDailyDairy> getAll()
        {
            return ConvertersDailyDairy.LfromTblToEntity(db.DailyDiaries.ToList());
        }

    }
}
