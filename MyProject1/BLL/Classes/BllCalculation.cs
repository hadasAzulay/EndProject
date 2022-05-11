using BLL.iClasses;
using DAL.DaliClasses;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;


namespace BLL.Classes
{
  public  class BllCalculation: IBllCalculation
    {
        IDalCalculation dal;
        public BllCalculation(IDalCalculation Dal)
        {
            dal = Dal;
        }
       public List<EntitiesCalculation> getAll() 
        {
            return dal.getAll();
        }
        public List<EntitiesCalculation> GetCalculationsOfProject(int proId)
        {
            return dal.GetCalculationsOfProject(proId);
        }
        public List<EntitiesCalculation> GetCalculationsBySupp(int supplierID)
        {
            return dal.GetCalculationsBySupp(supplierID);
        }
        public EntitiesCalculation GetCalculationbyCheckNu(string NumberCheck)
        {
            return dal.GetCalculationbyCheckNu(NumberCheck);
        }
        public List<EntitiesCalculation> putCalculation(EntitiesCalculation c) 
        {
            return dal.putCalculation(c);
        }

        public EntitiesCalculation GetCalculationbyDate(DateTime d)
        {
            return dal.GetCalculationbyDate(d);
        }
    }
}
