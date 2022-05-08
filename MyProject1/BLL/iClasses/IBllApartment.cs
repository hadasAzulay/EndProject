using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
   public interface IbllApartment
    {
        List<EntitiesApartment> getAll();
        List<EntitiesApartment> getAllApartmentsOfPerson(int pId);
        List<EntitiesApartment> deleteApartmentAftYear(DateTime d);


    }
}
