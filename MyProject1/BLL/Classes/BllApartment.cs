using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class bllApartment : IbllApartment
    {
        IDalApartment dal;
        public bllApartment(IDalApartment Dal)
        {
            dal = Dal;
        }
        public List<EntitiesApartment> getAll()
        {
            return dal.getAll();
        }
        public List<EntitiesApartment> getAllApartmentsOfPerson(int pId) 
        {
            return dal.getAllApartmentsOfPerson(pId);
        }
      public List<EntitiesApartment> deleteApartmentAftYear(DateTime d) 
        { return dal.deleteApartmentAftYear(d);
        }
    
    }
}
