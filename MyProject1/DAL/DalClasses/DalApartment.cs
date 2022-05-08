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
        //getAll 
        public List<EntitiesApartment> getAll()
        {
            return ConverterAparment.ToDalApartmentList(db.Apartments.ToList());
        }
        //
        //get All Apartments Of Person
        public List<EntitiesApartment> getAllApartmentsOfPerson(int pId)
        {
            List<EntitiesApartment> la = new List<EntitiesApartment>();
                foreach(var item in db.Apartments) 
            {
                EntitiesApartment a = ConverterAparment.ToDalApartment(db.Apartments.FirstOrDefault(x => x.CostumerId == pId));
                la.Add(a);
            }

            if (la == null)
            return null;
            return la;
        }
        //delete apartment after year
        public List<EntitiesApartment> deleteApartmentAftYear(DateTime d)
        {
            foreach (var item in db.Apartments)
            {
                Apartment a = db.Apartments.FirstOrDefault(apr => apr.KeyGetDate.Year + 1 == d.Year && apr.KeyGetDate.Month == d.Month && apr.KeyGetDate.Day == d.Day);
                db.Apartments.Remove(a);
            }
            return getAll();
        }
    }

}
