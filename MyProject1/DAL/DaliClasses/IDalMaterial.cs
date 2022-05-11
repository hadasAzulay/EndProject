using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
   public interface IDalMaterial
    {
        List<EntitiesMaterial> getAll();
        List<EntitiesMaterial> PutMaterial(EntitiesMaterial m);
        List<EntitiesMaterial> deleteMaterial(EntitiesMaterial m);
    }
}
