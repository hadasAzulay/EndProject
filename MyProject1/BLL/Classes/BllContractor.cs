using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
   public class BllContractor: IBllContractor
    {
        IDalContractor dal;
        public BllContractor(IDalContractor Dal)
        {
            dal = Dal;
        }
        public EntitiesContractor getByid(int id)
        {
            return dal.getByid(id);
        }
       public  EntitiesContractor getByEmail(string Email)
        {
            return dal.getByEmail(Email);
        }
       public EntitiesContractor getByPhone(string PhoneNumber)
        {
            return dal.getByPhone(PhoneNumber);
        }
       public List<EntitiesContractor> deleteContractor(EntitiesContractor c)
        {
            return dal.deleteContractor(c);
        }
       public List<EntitiesContractor> PutContractor(EntitiesContractor c)
        {
            return dal.deleteContractor(c);
        }
       public List<EntitiesContractor> getAll()
        {
            return dal.getAll();
        }
    }
}
