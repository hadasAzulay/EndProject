using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
 public   interface IDalCostumer
    {
        List<EntitiesCostumer> getAll();
        List<EntitiesCostumer> putCostumer(EntitiesCostumer c);
    }
}
