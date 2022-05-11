using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
   public interface IDalEquipmentForDay
    {
         List<EntitiesEquipmentForDay> getAll();
         List<EntitiesEquipmentForDay> putEquipmentForDay(EntitiesEquipmentForDay e);
    }
}
