using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
    public interface IDalProjects
    {
        List<EntitiesProject> getAllProjects();
        List<EntitiesProject> putProject(EntitiesProject p);
        List<EntitiesProject> getProjectsByType(int id);
    }
}