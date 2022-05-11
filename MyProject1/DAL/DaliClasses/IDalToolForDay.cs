using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
    public interface IDalToolForDay
    {
        List<EntitiesToolsForDay> PutDalToolsForDay(EntitiesToolsForDay t);
        List<EntitiesToolsForDay> DeleteDalToolsForDay(EntitiesToolsForDay t);
        List<EntitiesToolsForDay> getAll();
    }
}
