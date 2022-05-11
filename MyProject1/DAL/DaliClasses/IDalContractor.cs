using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
  public  interface IDalContractor
    {
        EntitiesContractor getByid(int id);
        EntitiesContractor getByEmail(string Email);
        EntitiesContractor getByPhone(string PhoneNumber);
        List<EntitiesContractor> deleteContractor(EntitiesContractor c);
        List<EntitiesContractor> PutContractor(EntitiesContractor c);
        List<EntitiesContractor> getAll();
    }
}
