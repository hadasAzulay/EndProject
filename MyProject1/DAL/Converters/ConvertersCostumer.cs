using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;



namespace DAL.Converters
{
   public class ConvertersCostumer
    {
        public static EntitiesCostumer fromTblToEntity(Costumer c)
        {
            return new EntitiesCostumer()
            {
                CostumersId = c.CostumersId,
                PersonId = c.PersonId,
                ProjectId = c.ProjectId
            };

        }
              public static Costumer fromEntityToTbl(EntitiesCostumer c)
        {
            return new Costumer()
            {
                CostumersId = c.CostumersId,
                PersonId = c.PersonId,
                ProjectId = c.ProjectId

            };
        }

      
      

        public static List<Costumer> LfromEntityToTbl(List<EntitiesCostumer> lc)
        {
            List<Costumer> l = new List<Costumer>();
            foreach (var item in lc)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesCostumer> LfromTblToEntity(List<Costumer> lc)
        {
            List<EntitiesCostumer> l = new List<EntitiesCostumer>();
            foreach (var item in lc)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
