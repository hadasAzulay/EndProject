using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
 public interface IDalEquipment
    {
        List<EntitiesEquipment> PutEquipment(EntitiesEquipment t);
        List<EntitiesEquipment> DeleteEquipment(EntitiesEquipment t);
        List<EntitiesEquipment> getAll();
    }
}
