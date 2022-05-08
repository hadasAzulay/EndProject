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
    public class DalPerson : IDalPerson
    {
        finalProject1Context db;
        public DalPerson(finalProject1Context DB)
        {
            db = DB;
        }
        //פונקציה לשליפת כל האנשים 
        public List<EntitiesPerson> getAll()
        {
            return ConvertersPerson.LfromTblToEntity(db.People.ToList());
        }
        //פונקציה להוספת אדם
        public List<EntitiesPerson> putPerson(EntitiesPerson p)
        {
            db.People.Add(ConvertersPerson.fromEntityToTbl(p));
            db.SaveChanges();
            return getAll();
        }//כניסה ע"י שם משתמש וסיסמא
        public EntitiesPerson getPersonByEmailAndPas(string email, string pass)
        {
            Person p = db.People.FirstOrDefault(x => x.Email == email && x.PsWord == pass);
            if (p == null)
                return null;
            return ConvertersPerson.fromTblToEntity(p);

        }
        //פונקציה של עידכון
        public List<EntitiesPerson> updatePerson(EntitiesPerson p)
        {
            Person p1 = db.People.FirstOrDefault(c => c.PersonId == p.PersonId);
            if (p1 != null)
            {
                //הצבת כל השדות שניתנים לשינוי בערכים חדשים
                //לדוג בלי הקוד
                p1.Email = p.Email;
                p1.FirstName = p.FirstName;
                p1.LastName = p.LastName;
                p1.PhoneNumber = p.PhoneNumber;
                p1.PsWord = p.PsWord;
                db.SaveChanges();
                return getAll();

            }
            return null;
        }
        public EntitiesPerson UpdateUser(EntitiesPerson user)//ch
        {
            Person userToUpdate = db.People.FirstOrDefault(x => x.Email.Equals(user.Email));
            //   userToUpdate = Convert.UserConvert.UserToModel(user);
            db.People.Update(userToUpdate);
            return ConvertersPerson.fromTblToEntity(userToUpdate);


        }


    }
}
 