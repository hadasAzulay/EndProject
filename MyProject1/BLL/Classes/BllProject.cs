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
    }
}
