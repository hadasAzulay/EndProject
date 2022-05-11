using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;

namespace BLL.Classes
{
    public class BllPerson : IBllPerson
    {
        IDalPerson pDal;
        public BllPerson(IDalPerson p)
        {
            pDal = p;
        }

        public List<EntitiesPerson> getAll()
        {
            return pDal.getAll();
        }


        public List <EntitiesPerson> putPerson(EntitiesPerson p)
        {
            return pDal.putPerson(p);
        }


        public EntitiesPerson getPersonByEmailAndPas(string email, string pass)
        {
            return pDal.getPersonByEmailAndPas(email,pass);
        }

    
          

        public List<EntitiesPerson> updatePerson(EntitiesPerson p)
        {
                return pDal.updatePerson(p);
            }
        }
    }
    
