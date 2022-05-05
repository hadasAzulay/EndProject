using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersLevelType
    {
        public static EntitiesLevelType fromTblToEntity(LevelType l)
        {
            return new EntitiesLevelType()
            {
                LevelType1 = l.LevelType1,
                LevelName = l.LevelName
            };
        }
        public static LevelType fromEntityToTbl(EntitiesLevelType l)
        {
            return new LevelType()
            {
                LevelType1 = l.LevelType1,
                LevelName = l.LevelName
            };
        }
        public static List<LevelType> LfromEntityToTbl(List<EntitiesLevelType> ll)
        {
            List<LevelType> l = new List<LevelType>();
            foreach (var item in ll)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesLevelType> LfromTblToEntity(List<LevelType> ll)
        {
            List<EntitiesLevelType> l = new List<EntitiesLevelType>();
            foreach (var item in ll)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
