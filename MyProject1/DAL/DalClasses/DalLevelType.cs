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
  public  class DalLevelType: IDalLevelType
    {

        finalProject1Context db;
        public DalLevelType(finalProject1Context db)
        {
            this.db = db;
        }
        public List<EntitiesLevelType> getAll()
        {
            return ConvertersLevelType.LfromTblToEntity(db.LevelTypes.ToList());
        }
    }
}
