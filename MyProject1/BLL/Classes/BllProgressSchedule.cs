using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;

namespace BLL.Classes
{
    public class BllProgressSchedule : IBllProgressSchedule
    {

        IDalProgressSchedule dal;
        public BllProgressSchedule(IDalProgressSchedule Dal)
        {
            dal = Dal;
        }
        public EntitiesProgressSchedule getByBroject(int proId)
        {
            return dal.getByBroject(proId);
                }

        public EntitiesProgressSchedule getByDate(DateTime d)
        {
            return dal.getByDate(d);
        }
    }
}
