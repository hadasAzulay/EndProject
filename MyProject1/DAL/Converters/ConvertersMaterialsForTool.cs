using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersMaterialsForTool
    {
        public static EntitiesMaterialsForTool fromTblToEntity(MaterialsForTool m)
        {
            return new EntitiesMaterialsForTool()
            {
                MaterialsForTools=m.MaterialsForTools,
                MaterialsId=m.MaterialsId,
                DoubtId=m.DoubtId
            };
        }
        public static MaterialsForTool fromEntityToTbl(EntitiesMaterialsForTool m)
        {
            return new MaterialsForTool()
            {
                MaterialsForTools = m.MaterialsForTools,
                MaterialsId = m.MaterialsId,
                DoubtId = m.DoubtId
            };
        }
        public static List<MaterialsForTool> LfromEntityToTbl(List<EntitiesMaterialsForTool> lm)
        {
            List<MaterialsForTool> l = new List<MaterialsForTool>();
            foreach (var item in lm)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesMaterialsForTool> LfromTblToEntity(List<MaterialsForTool> lm)
        {
            List<EntitiesMaterialsForTool> l = new List<EntitiesMaterialsForTool>();
            foreach (var item in lm)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
