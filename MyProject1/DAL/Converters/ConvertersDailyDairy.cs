using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;


namespace DAL.Converters
{
    class ConvertersDailyDairy
    
        {
        public static EntitiesDailyDairy fromTblToEntity(DailyDiary d)
        {
            return new EntitiesDailyDairy()
            {
                DailyDiary1 = d.DailyDiary1,
                ProjectId = d.ProjectId,
                DateOfToday = d.DateOfToday,
                DetailsOfTheWork = d.DetailsOfTheWork,
                Notes = d.Notes,
                BeginingHour = d.BeginingHour,
                EndHour = d.EndHour

            };
            }
        
            public static DailyDiary fromEntityToTbl(EntitiesDailyDairy d)
            {
                return new DailyDiary()
                {
                    DailyDiary1 = d.DailyDiary1,
                    ProjectId = d.ProjectId,
                    DateOfToday = d.DateOfToday,
                    DetailsOfTheWork = d.DetailsOfTheWork,
                    Notes = d.Notes,
                    BeginingHour = d.BeginingHour,
                    EndHour = d.EndHour
                };
            }
            public static List<DailyDiary> LfromEntityToTbl(List<EntitiesDailyDairy> ld)
            {
                List<DailyDiary> l = new List<DailyDiary>();
                foreach (var item in ld)
                {
                    l.Add(fromEntityToTbl(item));
                }
                return l;
            }
            public static List<EntitiesDailyDairy> LfromTblToEntity(List<DailyDiary> ld)
            {
                List<EntitiesDailyDairy> l = new List<EntitiesDailyDairy>();
                foreach (var item in ld)
                {
                    l.Add(fromTblToEntity(item));
                }
                return l;
            }
        }
    }
