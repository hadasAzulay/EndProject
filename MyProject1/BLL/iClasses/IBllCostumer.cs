using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllCostumer
    {
        List<EntitiesCostumer> getAll();
        List<EntitiesCostumer> putCostumer(EntitiesCostumer c);
    }
}
