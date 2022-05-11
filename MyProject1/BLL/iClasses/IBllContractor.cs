using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.iClasses
{
  public  interface IBllContractor
    {
        EntitiesContractor getByid(int id);
        EntitiesContractor getByEmail(string Email);
        EntitiesContractor getByPhone(string PhoneNumber);
        List<EntitiesContractor> deleteContractor(EntitiesContractor c);
        List<EntitiesContractor> PutContractor(EntitiesContractor c);
        List<EntitiesContractor> getAll();
    }
}
