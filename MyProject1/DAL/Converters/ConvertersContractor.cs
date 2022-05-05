using DAL.models;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Converters
{
   public class ConvertersContractor
    {
        public static EntitiesContractor fromTblToEntity(Contractor c)
        {
            return new EntitiesContractor()
            {
             ContractorId =c.ContractorId,
             PersonId =c.PersonId,
             ContractorRole =c.ContractorRole,
             Advertising=c.Advertising,
             CpaId=c.CpaId
      };
        }
        public static Contractor fromEntityToTbl(EntitiesContractor c)
        {
            return new Contractor()
            {
                ContractorId = c.ContractorId,
                PersonId = c.PersonId,
                ContractorRole = c.ContractorRole,
                Advertising = c.Advertising,
                CpaId = c.CpaId

            };
        }
        public static List<Contractor> LfromEntityToTbl(List<EntitiesContractor> lc)
        {
            List<Contractor> l = new List<Contractor>();
            foreach (var item in lc)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesContractor> LfromTblToEntity(List<Contractor> lc)
        {
            List<EntitiesContractor> l = new List<EntitiesContractor>();
            foreach (var item in lc)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
