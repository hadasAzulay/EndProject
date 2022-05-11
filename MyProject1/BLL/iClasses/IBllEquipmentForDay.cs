using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllEquipmentForDay
    {
        List<EntitiesEquipmentForDay> getAll();
        List<EntitiesEquipmentForDay> putEquipmentForDay(EntitiesEquipmentForDay e);
    }
}
