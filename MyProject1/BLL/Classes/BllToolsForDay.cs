using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class BllToolsForDay : IBllToolForDay
    {
        IDalToolForDay dal;
        public BllToolsForDay(IDalToolForDay Dal)
        {
            dal = Dal;
        }
        public List<EntitiesToolsForDay> DeleteDalToolsForDay(EntitiesToolsForDay t)
        {
            return dal.DeleteDalToolsForDay(t);    
        }

        public List<EntitiesToolsForDay> getAll()
        {
            return dal.getAll();
        }

        public List<EntitiesToolsForDay> PutDalToolsForDay(EntitiesToolsForDay t)
        {
            return dal.PutDalToolsForDay(t);
        }
    }
}
