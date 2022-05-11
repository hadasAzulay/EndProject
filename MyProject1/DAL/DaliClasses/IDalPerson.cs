using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
 public  interface IDalPerson
    {
        
        List<EntitiesPerson> getAll();
        List<EntitiesPerson> putPerson(EntitiesPerson p);
        EntitiesPerson getPersonByEmailAndPas(string email, string pass);
        List<EntitiesPerson> updatePerson(EntitiesPerson p);
    }
}
