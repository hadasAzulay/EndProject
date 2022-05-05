using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersSupplier
    {
        public static EntitiesSupplier fromTblToEntity(Supplier s)
        {
            return new EntitiesSupplier()
            {
               Advertising=s.Advertising,
               DoubtId=s.DoubtId,
               PersonId=s.PersonId,
               CpaId=s.CpaId
            };
        }
        public static Supplier fromEntityToTbl(EntitiesSupplier s)
        {
            return new Supplier()
            {
                Advertising = s.Advertising,
                DoubtId = s.DoubtId,
                PersonId = s.PersonId,
                CpaId = s.CpaId
            };
        }
        public static List<Supplier> LfromEntityToTbl(List<EntitiesSupplier> ls)
        {
            List<Supplier> l = new List<Supplier>();
            foreach (var item in ls)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesSupplier> LfromTblToEntity(List<Supplier> ls)
        {
            List<EntitiesSupplier> l = new List<EntitiesSupplier>();
            foreach (var item in ls)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
