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
 public class DalContractor:IDalContractor//קבלן
    {
        finalProject1Context db;
        public DalContractor(finalProject1Context db)
        {
            this.db = db;
        }
        public List<EntitiesContractor> getAll()
        {
            return ConvertersContractor.LfromTblToEntity(db.Contractors.ToList());
        }

    }
}
