
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL.Converters
{
   public class ConverterAparment
    {
        //(entities) למחלקה שלנו (dal)המרה ממיקרוסופט
        public static DAL.models.Apartment ToEntitiesApartment(Entities.EntitiesClasses.EntitiesApartment a)
        {
            DAL.models.Apartment a1 = new models.Apartment();
            a1.ApartmentId = a.ApartmentId;
            a1.ProjectId = a.ProjectId;
            a1.KeyGetDate = a.KeyGetDate;
            a1.CostumerId = a.CostumersId;
            return a1;
        }
        //(dal) למיקרוסופט (entities)  המרה ממחלקה שלנו
        public static Entities.EntitiesClasses.EntitiesApartment ToDalApartment(DAL.models.Apartment a)
        {
            Entities.EntitiesClasses.EntitiesApartment a1 = new Entities.EntitiesClasses.EntitiesApartment();
            a1.ApartmentId = a.ApartmentId;
            a1.ProjectId = a.ProjectId;
            a1.KeyGetDate = a.KeyGetDate;
            a1.CostumersId = a.CostumerId;
            return a1;
        }
        //convert To Entities list from Dal list
        public static List<DAL.models.Apartment> ToEntitiesApartmentList (List<Entities.EntitiesClasses.EntitiesApartment> la)
        {
            List <DAL.models.Apartment> la1 = new List<models.Apartment>();
            foreach (var item in la)
            {
                la1.Add(ToEntitiesApartment(item));
            }
            return la1;
        }
        //convert To   Dal list from Entities list
        public static List<Entities.EntitiesClasses.EntitiesApartment> ToDalApartmentList(List<DAL.models.Apartment> la)
        {
            List<Entities.EntitiesClasses.EntitiesApartment> la1 = new List<Entities.EntitiesClasses.EntitiesApartment>();
            foreach (var item in la)
            {
                la1.Add(ToDalApartment(item));
            }
            return la1;
        }


    }
}
