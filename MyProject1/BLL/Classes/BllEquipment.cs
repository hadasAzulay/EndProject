using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;

namespace BLL.Classes
{
    public class BllEquipment : IBllEquipment
    {

        IDalEquipment dal;
        public BllEquipment(IDalEquipment Dal)
        {
            dal = Dal;
        }
        public List<EntitiesEquipment> PutEquipment(EntitiesEquipment t)
        {
            return dal.PutEquipment(t);
        }
        public List<EntitiesEquipment> DeleteEquipment(EntitiesEquipment t)
        {
            return dal.DeleteEquipment(t);
        }
        public List<EntitiesEquipment> getAll()
        {
            return dal.getAll();
        }
    }
}
