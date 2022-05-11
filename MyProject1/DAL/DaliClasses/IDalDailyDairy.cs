using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
   public interface IDalDailyDairy
    {
        List<EntitiesDailyDairy> getAll();
        List<EntitiesDailyDairy> putDailyDairy(EntitiesDailyDairy d);
        List<EntitiesDailyDairy> deleteDairyDaily(EntitiesDailyDairy d);
        bool GetAlerts(EntitiesDailyDairy d);
    }
}
