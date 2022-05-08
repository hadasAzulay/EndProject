using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
   public interface IDalApartment
    {
         List<EntitiesApartment> getAll();
        List<EntitiesApartment> getAllApartmentsOfPerson(int pId);
        List<EntitiesApartment> deleteApartmentAftYear(DateTime d);
    }
}
