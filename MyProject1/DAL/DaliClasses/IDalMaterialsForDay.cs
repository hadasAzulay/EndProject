using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
  public  interface IDalMaterialsForDay
    {
        List<EntitiesMaterialsForDay> PutMaterialsForDay(EntitiesMaterialsForDay m);
        List<EntitiesMaterialsForDay> deleteMaterialsForDay(EntitiesMaterialsForDay m);
        List<EntitiesMaterialsForDay> getAll();
    }
}
