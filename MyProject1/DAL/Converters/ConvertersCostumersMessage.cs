using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;


    namespace DAL.Converters
    {
        class ConvertersCostumersMessage
        {
        public static EntitiesCostumerMessage fromTblToEntity(CostumersMessage c)
        {
            return new EntitiesCostumerMessage()
            { 
                MessageId =c.MessageId,
                ProjectId=c.ProjectId,
                Discraption=c.Discraption,
               
            };

        }
        public static CostumersMessage fromEntityToTbl(EntitiesCostumerMessage c)
        {
            return new CostumersMessage()
            {
                MessageId = c.MessageId,
                ProjectId = c.ProjectId,
                Discraption = c.Discraption,
            

            };
        }
        public static List<CostumersMessage> LfromEntityToTbl(List<EntitiesCostumerMessage> lc)
        {
            List<CostumersMessage> l = new List<CostumersMessage>();
            foreach (var item in lc)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesCostumerMessage> LfromTblToEntity(List<CostumersMessage> lc)
        {
            List<EntitiesCostumerMessage> l = new List<EntitiesCostumerMessage>();
            foreach (var item in lc)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}


