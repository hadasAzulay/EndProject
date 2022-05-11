using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;

namespace BLL.Classes
{
    public class BllEquipmentForDay : IBllEquipmentForDay
    {

        IDalEquipmentForDay dal;
        public BllEquipmentForDay(IDalEquipmentForDay Dal)
        {
            dal = Dal;
        }
        public List<EntitiesEquipmentForDay> getAll()
        {
            return dal.getAll();
        }

        public List<EntitiesEquipmentForDay> putEquipmentForDay(EntitiesEquipmentForDay e)
        {
            return dal.putEquipmentForDay(e);
        }
    }
}
