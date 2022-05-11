using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
   public class BllProject: IBllProjectcs
    {
        IDalProjects pDal;
        public BllProject(IDalProjects p)
        {
            pDal = p;
        }
        public List<EntitiesProject> getAllProjects()
        {
           return pDal.getAllProjects();
        }

        public List<EntitiesProject> getProjectsByType(int id)
        {
            return pDal.getProjectsByType(id);
        }

        public List<EntitiesProject> putProject(EntitiesProject p)
        {
            return pDal.putProject(p);
        }
    }
}
