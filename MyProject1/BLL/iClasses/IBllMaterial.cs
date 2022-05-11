using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllMaterial
    {
        List<EntitiesMaterial> getAll();
        List<EntitiesMaterial> PutMaterial(EntitiesMaterial m);
        List<EntitiesMaterial> deleteMaterial(EntitiesMaterial m);
    }
}
