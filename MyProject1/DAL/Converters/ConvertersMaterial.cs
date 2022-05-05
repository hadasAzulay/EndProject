using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersMaterial
    {
        public static EntitiesMaterial fromTblToEntity(Material m)
        {
            return new EntitiesMaterial()
            {
                MaterialsId=m.MaterialsId,
                MaterialsName=m.MaterialsName
            };
        }
        public static Material fromEntityToTbl(EntitiesMaterial m)
        {
            return new Material()
            {

                MaterialsId = m.MaterialsId,
                MaterialsName = m.MaterialsName
            };
        }
        public static List<Material> LfromEntityToTbl(List<EntitiesMaterial> lm)
        {
            List<Material> l = new List<Material>();
            foreach (var item in lm)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesMaterial> LfromTblToEntity(List<Material> lm)
        {
            List<EntitiesMaterial> l = new List<EntitiesMaterial>();
            foreach (var item in lm)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
