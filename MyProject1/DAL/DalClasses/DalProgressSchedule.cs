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
   public class DalProgressSchedule: IDalProgressSchedule
    {
        finalProject1Context db;
        public DalProgressSchedule(finalProject1Context db)
        {
            this.db = db;
        }
        public EntitiesProgressSchedule getByDate(DateTime d) 
        {
            ProgressSchedule pd = db.ProgressSchedules.FirstOrDefault(x => x.DateOfToday== d);
            if (pd != null)
                return ConvertersProgressSchedule.fromTblToEntity(pd);
            return null;
        
        }
        public EntitiesProgressSchedule getByBroject(int proId)
        {
            ProgressSchedule pro = db.ProgressSchedules.FirstOrDefault(x => x.ProjectId == proId);
            if (pro != null)
                return ConvertersProgressSchedule.fromTblToEntity(pro);
            return null;

        }
    }

}
