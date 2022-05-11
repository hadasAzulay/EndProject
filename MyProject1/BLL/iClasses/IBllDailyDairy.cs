using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IBllDailyDairy
    {
        List<EntitiesDailyDairy> getAll();
        List<EntitiesDailyDairy> putDailyDairy(EntitiesDailyDairy d);
        List<EntitiesDailyDairy> deleteDairyDaily(EntitiesDailyDairy d);
        bool GetAlerts(EntitiesDailyDairy d);
    }
}
