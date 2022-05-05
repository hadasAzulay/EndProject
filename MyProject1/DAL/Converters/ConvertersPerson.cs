using DAL.models;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Converters
{
  public  class ConvertersPerson
    {
        public static EntitiesPerson fromTblToEntity(Person p)
        {
            return new EntitiesPerson() {
                PersonId = p.PersonId,
                FirstName=p.FirstName,
                LastName=p.LastName,
                PhoneNumber=p.PhoneNumber,
                Email=p.Email,
                PsWord=p.PsWord
            };
        }
        public static Person fromEntityToTbl( EntitiesPerson p)
        {
            return new Person()
            {
                PersonId = p.PersonId,
                FirstName = p.FirstName,
                LastName = p.LastName,
                PhoneNumber = p.PhoneNumber,
                Email = p.Email,
                PsWord = p.PsWord
            };
        }
        public static List<Person> LfromEntityToTbl(List<EntitiesPerson> lp)
        {
            List<Person> l = new List<Person>();
            foreach (var item in lp)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesPerson> LfromTblToEntity(List<Person> lp)
        {
            List<EntitiesPerson> l = new List<EntitiesPerson>();
            foreach (var item in lp)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
