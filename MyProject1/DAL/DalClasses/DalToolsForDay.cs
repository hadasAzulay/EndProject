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
    public class DalToolsForDay: IDalToolForDay
    {
            finalProject1Context db;
            public DalToolsForDay(finalProject1Context DB)
            {
                db = DB;
            }
        //Add
        public List<EntitiesToolsForDay> PutDalToolsForDay(EntitiesToolsForDay t )
        {
            db.ToolsForDays.Add(ConvertersToolsForDay.fromEntityToTbl(t));
            db.SaveChanges();
            return getAll();
        }
        //getAll
        public List<EntitiesToolsForDay> getAll()
            {
                return ConvertersToolsForDay.LfromTblToEntity(db.ToolsForDays.ToList());
            }
        }
}
