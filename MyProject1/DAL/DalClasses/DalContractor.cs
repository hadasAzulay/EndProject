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
 public class DalContractor:IDalContractor//קבלן
    {
        finalProject1Context db;
        public DalContractor(finalProject1Context db)
        {
            this.db = db;
        }
        public List<EntitiesContractor> getAll()
        {
            return ConvertersContractor.LfromTblToEntity(db.Contractors.ToList());
        }
        //Add

        public List<EntitiesContractor> PutContractor(EntitiesContractor c)
        {
            db.Contractors.Add(ConvertersContractor.fromEntityToTbl(c));
            db.SaveChanges();
            return getAll();
        }
        //delete

        public List<EntitiesContractor> deleteContractor(EntitiesContractor c)
        {
            db.Contractors.Remove(ConvertersContractor.fromEntityToTbl(c));
            db.SaveChanges();
            return getAll();
        }
        public EntitiesContractor getByPhone(string PhoneNumber)
        {
            Person p = db.People.FirstOrDefault(x => x.PhoneNumber == PhoneNumber);
            Contractor c = db.Contractors.FirstOrDefault(x => x.PersonId == p.PersonId);
            if (c != null)
                return ConvertersContractor.fromTblToEntity(c);
            return null;

        }

        public EntitiesContractor getByEmail(string Email)
        {
            Person p = db.People.FirstOrDefault(x => x.Email == Email);
            Contractor c = db.Contractors.FirstOrDefault(x => x.PersonId == p.PersonId);
            if (c != null)
                return ConvertersContractor.fromTblToEntity(c);
            return null;
        }
        public EntitiesContractor getByid(int id)
        {

            Contractor c = db.Contractors.FirstOrDefault(x => x.ContractorId == id);
            if (c != null)
                return ConvertersContractor.fromTblToEntity(c);
            return null;

        }
    }
}

