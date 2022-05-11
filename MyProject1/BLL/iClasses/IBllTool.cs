using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllTool
    {
        List<EntitiesTool> PutTool(EntitiesTool t);
        List<EntitiesTool> DeleteDalToolsForDay(EntitiesTool t);
        EntitiesTool getByName(string name);
        EntitiesTool getById(int id);
        List<EntitiesTool> getAll();
    }
}
