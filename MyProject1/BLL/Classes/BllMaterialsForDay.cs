using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;

namespace BLL.Classes
{
   public class BllMaterialsForDay: IBllMaterialsForDay
    {

        IDalMaterialsForDay dal;
        public BllMaterialsForDay(IDalMaterialsForDay Dal)
        {
            dal = Dal;
        }
        public List<EntitiesMaterialsForDay> PutMaterialsForDay(EntitiesMaterialsForDay m)
        {
            return dal.PutMaterialsForDay(m);
        }
        public List<EntitiesMaterialsForDay> deleteMaterialsForDay(EntitiesMaterialsForDay m)
        {
            return dal.deleteMaterialsForDay(m);
        }
        public List<EntitiesMaterialsForDay> getAll()
        {
            return dal.getAll();
        }
    }
}
