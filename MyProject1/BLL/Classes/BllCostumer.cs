using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
   public class BllCostumer: IBllCostumer
    {
        IDalCostumer dal;
        public BllCostumer(IDalCostumer Dal)
        {
            dal = Dal;
        }
        public List<EntitiesCostumer> getAll()
        {
            return dal.getAll();
        }
      public  List<EntitiesCostumer> putCostumer(EntitiesCostumer c)
        {
            return dal.putCostumer(c);
        }
    }
}
