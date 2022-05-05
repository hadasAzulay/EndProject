using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;


namespace BLL.iClasses
{
   public interface IBllPerson
    {
        List<EntitiesPerson> getAll();
        List<EntitiesPerson> putPerson(EntitiesPerson p);
        EntitiesPerson getPersonByEmailAndPas(string email, string pass);
    }
}
