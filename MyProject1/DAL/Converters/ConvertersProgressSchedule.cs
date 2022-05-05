using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersProgressSchedule
    {
        public static EntitiesProgressSchedule fromTblToEntity(ProgressSchedule p)
        {
            return new EntitiesProgressSchedule()
            {
               ProgressScheduleId=p.ProgressScheduleId,
               LevelTypeId=p.LevelTypeId,
               ProjectId=p.ProjectId,
               Discraption=p.Discraption,
               DateOfToday=p.DateOfToday
            };
        }
        public static ProgressSchedule fromEntityToTbl(EntitiesProgressSchedule p)
        {
            return new ProgressSchedule()
            {
                ProgressScheduleId = p.ProgressScheduleId,
                LevelTypeId = p.LevelTypeId,
                ProjectId = p.ProjectId,
                Discraption = p.Discraption,
                DateOfToday = p.DateOfToday
            };
        }
        public static List<ProgressSchedule> LfromEntityToTbl(List<EntitiesProgressSchedule> lp)
        {
            List<ProgressSchedule> l = new List<ProgressSchedule>();
            foreach (var item in lp)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesProgressSchedule> LfromTblToEntity(List<ProgressSchedule> lp)
        {
            List<EntitiesProgressSchedule> l = new List<EntitiesProgressSchedule>();
            foreach (var item in lp)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
