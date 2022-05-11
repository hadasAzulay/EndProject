using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
  public interface IDalProgressSchedule
    {
        EntitiesProgressSchedule getByDate(DateTime d);
        EntitiesProgressSchedule getByBroject(int proId);
    }
}
