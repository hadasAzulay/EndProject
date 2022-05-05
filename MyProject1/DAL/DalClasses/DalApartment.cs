using DAL.Converters;
using DAL.DaliClasses;
using DAL.models;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DalClasses
{
    public class DalApartment : IDalApartment
    {
        finalProject1Context db;
        public DalApartment(finalProject1Context db)
        {
            this.db = db;
        }
        public List<EntitiesApartment> getAll()
        {
            return ConverterAparment.ToDalApartmentList(db.Apartments.ToList());
        }
        public List<EntitiesApartment> getAllApartmentsOfPerson(int pId)
        {
            Apartment a = db.Apartments.FirstOrDefault(x => x.CostumerId == pId);
            if (a != null)
            {
            }
            return null;
        }
       
    }

}
