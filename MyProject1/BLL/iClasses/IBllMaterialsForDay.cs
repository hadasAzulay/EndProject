using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllMaterialsForDay
    {
        List<EntitiesMaterialsForDay> PutMaterialsForDay(EntitiesMaterialsForDay m);
        List<EntitiesMaterialsForDay> deleteMaterialsForDay(EntitiesMaterialsForDay m);
        List<EntitiesMaterialsForDay> getAll();
    }
}
