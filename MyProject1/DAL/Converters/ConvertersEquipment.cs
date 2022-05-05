using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
   public class ConvertersEquipment
    {
       public static EntitiesEquipment fromTblToEntity (Equipment e) 
        {
            return new EntitiesEquipment()
            {
                EquipmentId=e.EquipmentId,
                EquipmentName=e.EquipmentName
            };
        }
        public static Equipment fromEntityToTbl(EntitiesEquipment e)
        {
            return new Equipment()
            {
                EquipmentId = e.EquipmentId,
                EquipmentName = e.EquipmentName
            };
        }
        public static List<Equipment> LfromEntityToTbl(List<EntitiesEquipment> le)
        {
            List<Equipment> l = new List<Equipment>();
            foreach (var item in le)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesEquipment> LfromTblToEntity(List<Equipment> le)
        {
            List<EntitiesEquipment> l = new List<EntitiesEquipment>();
            foreach (var item in le)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }

    }
}
