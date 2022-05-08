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
  public  class DalCalculation:IDalCalculation

        {
            finalProject1Context db;
            public DalCalculation(finalProject1Context db)
            {
                this.db = db;
            }
            public List<EntitiesCalculation> getAll()
            {
                return ConverterCalculation.LfromTblToEntity(db.Calculations.ToList());
            }
            //search calculation with projectID
        public List<EntitiesCalculation> GetCalculationsOfProject(int proId) 
        {
            List < EntitiesCalculation > lc = new List<EntitiesCalculation>();
            foreach(var item in db.Calculations) { 
            Calculation c = db.Calculations.FirstOrDefault(x => x.ProjectId == proId);
            lc.Add(ConverterCalculation.fromTblToEntity(c));
            }
            return lc;
        }
        //search calculation with projectID
        public List<EntitiesCalculation> GetCalculationsBySupp(int supplierID)
        {
            List<EntitiesCalculation> lc = new List<EntitiesCalculation>();
            foreach (var item in db.Calculations)
            {
                Calculation c = db.Calculations.FirstOrDefault(x => x.DoubtId == supplierID);
                lc.Add(ConverterCalculation.fromTblToEntity(c));
            }
            return lc;
        }
        //search calculation by check number
        public EntitiesCalculation GetCalculationbyCheckNu(string NumberCheck)
        {
            Calculation c = db.Calculations.FirstOrDefault(x => x.CheckNumber == NumberCheck);
            if (c != null)
                return ConverterCalculation.fromTblToEntity(c);
            return null;
        }
        //add calculattion
        public List<EntitiesCalculation> putCalculation(EntitiesCalculation c) 
       {
            db.Add(ConverterCalculation.fromEntityToTbl(c));
            db.SaveChanges();
            return getAll();
        }
       




        }
}
