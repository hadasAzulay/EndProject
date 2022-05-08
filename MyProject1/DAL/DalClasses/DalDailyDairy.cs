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
        public List<EntitiesDailyDairy>putDailyDairy(EntitiesDailyDairy d) 
        {
            db.DailyDiaries.Add(Converters.ConvertersDailyDairy.fromEntityToTbl(d));
            db.SaveChanges();
            return getAll();
        }
        public List<EntitiesDailyDairy> deleteDairyDaily(EntitiesDailyDairy d) //מקבל ENTITIES או TBL?
        {
            db.DailyDiaries.Remove(ConvertersDailyDairy.fromEntityToTbl(d));
            db.SaveChanges();
            return getAll();
        }
        //???
        public bool GetAlerts(EntitiesDailyDairy d)
        {
            if (d.Notes.Contains('$')) 
                return true;
                return false;
            
        } //????
        public float GetHoursOfWork(EntitiesDailyDairy e)
        {
            TimeSpan tStart = e.BeginingHour;
            TimeSpan tEnd = e.EndHour;
            return ((tEnd.Hours - tStart.Hours)+(tEnd.Minutes-tStart.Minutes));
        }



    }
}
