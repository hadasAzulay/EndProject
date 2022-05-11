using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;

namespace BLL.Classes
{
    public class BllMaterial:IBllMaterial
    {

        IDalMaterial dal;
        public BllMaterial(IDalMaterial Dal)
        {
            dal = Dal;
        }
        public List<EntitiesMaterial> getAll()
        {
            return dal.getAll();
        }
      public List<EntitiesMaterial> PutMaterial(EntitiesMaterial m)
        {
            return dal.PutMaterial(m);
        }
      public List<EntitiesMaterial> deleteMaterial(EntitiesMaterial m)
        {
            return dal.deleteMaterial(m);
        }

       
    }
}
