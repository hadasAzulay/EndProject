using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class BllTool : IBllTool
    {
        IDalTool pDal;
        public BllTool(IDalTool p)
        {
            pDal = p;
        }
        public List<EntitiesTool> DeleteDalToolsForDay(EntitiesTool t)
        {
            return pDal.DeleteDalToolsForDay(t);
        }

        public List<EntitiesTool> getAll()
        {
            return pDal.getAll();
        }

        public EntitiesTool getById(int id)
        {
            return pDal.getById(id);
        }

        public EntitiesTool getByName(string name)
        {
            return pDal.getByName(name);
        }

        public List<EntitiesTool> PutTool(EntitiesTool t)
        {
            return pDal.PutTool(t);
        }
    }
}
