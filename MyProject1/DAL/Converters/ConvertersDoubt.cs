using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersDoubt
    {
        public static EntitiesDoubt fromTblToEntity(Doubt d)
        {
            return new EntitiesDoubt()
            {
                DoubtId = d.DoubtId,
                PersonId = d.PersonId,
                Advertising = d.Advertising,
                CpaId = d.CpaId

            };
        }

        public static Doubt fromEntityToTbl(EntitiesDoubt d)
        {
            return new Doubt()
            {
                DoubtId = d.DoubtId,
                PersonId = d.PersonId,
                Advertising = d.Advertising,
                CpaId = d.CpaId
            };
        }
        public static List<Doubt> LfromEntityToTbl(List<EntitiesDoubt> ld)
        {
            List<Doubt> l = new List<Doubt>();
            foreach (var item in ld)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesDoubt> LfromTblToEntity(List<Doubt> ld)
        {
            List<EntitiesDoubt> l = new List<EntitiesDoubt>();
            foreach (var item in ld)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }

    }
}
