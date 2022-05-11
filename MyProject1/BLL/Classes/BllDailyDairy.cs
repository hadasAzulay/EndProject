using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;

namespace BLL.Classes
{
  public  class BllDailyDairy:IBllDailyDairy
    {

        IDalDailyDairy dal;
        public BllDailyDairy(IDalDailyDairy Dal)
        {
            dal = Dal;
        }
       public List<EntitiesDailyDairy> getAll()
        {
            return dal.getAll();
        }
       public List<EntitiesDailyDairy> putDailyDairy(EntitiesDailyDairy d)
        {
            return dal.putDailyDairy(d);
        }
       public List<EntitiesDailyDairy> deleteDairyDaily(EntitiesDailyDairy d)
        {
            return dal.deleteDairyDaily(d);
        }
       public bool GetAlerts(EntitiesDailyDairy d)
        {
            return dal.GetAlerts(d);

        }
    }
}
