using DAL.DaliClasses;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DalClasses
{
   public class DalCostumersMessage: IDalCostumersMessage
    {
        finalProject1Context db;
        public DalCostumersMessage(finalProject1Context db)
        {
            this.db = db;
        }
    

    }
}
