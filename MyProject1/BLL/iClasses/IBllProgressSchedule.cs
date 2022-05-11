﻿using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
  public interface IBllProgressSchedule
    {
        EntitiesProgressSchedule getByDate(DateTime d);
        EntitiesProgressSchedule getByBroject(int proId);
    }
}
