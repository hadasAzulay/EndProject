using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllToolForDay
    {
        List<EntitiesToolsForDay> PutDalToolsForDay(EntitiesToolsForDay t);
        List<EntitiesToolsForDay> DeleteDalToolsForDay(EntitiesToolsForDay t);
        List<EntitiesToolsForDay> getAll();
    }
}
