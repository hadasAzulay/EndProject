using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllEquipment
    {
        List<EntitiesEquipment> PutEquipment(EntitiesEquipment t);
        List<EntitiesEquipment> DeleteEquipment(EntitiesEquipment t);
        List<EntitiesEquipment> getAll();
    }
}
