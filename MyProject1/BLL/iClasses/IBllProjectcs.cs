using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllProjectcs

    {
        List<EntitiesProject> getAllProjects();

    }
}
