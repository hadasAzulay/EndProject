using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DaliClasses
{
 public   interface IDalCalculation
    {
        List<EntitiesCalculation> getAll();
        List<EntitiesCalculation> GetCalculationsOfProject(int proId);
        List<EntitiesCalculation> GetCalculationsBySupp(int supplierID);
        EntitiesCalculation GetCalculationbyCheckNu(string NumberCheck);
        List<EntitiesCalculation> putCalculation(EntitiesCalculation c);
        EntitiesCalculation GetCalculationbyDate(DateTime d);
        
    }
}
