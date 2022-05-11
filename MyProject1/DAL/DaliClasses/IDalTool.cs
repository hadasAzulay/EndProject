using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
   public interface IDalTool
    {
        List<EntitiesTool> PutTool(EntitiesTool t);
         List<EntitiesTool> DeleteDalToolsForDay(EntitiesTool t);
         EntitiesTool getByName(string name);
         EntitiesTool getById(int id);
         List<EntitiesTool> getAll();
    }
}
