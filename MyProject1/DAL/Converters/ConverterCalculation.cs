using DAL.models;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Converters
{
    public class ConverterCalculation
    {
        public static EntitiesCalculation fromTblToEntity(Calculation c)
        {
            return new EntitiesCalculation()
            {
                Calculations = c.Calculations,
                ProjectId = c.ProjectId,
                DoubtId = c.DoubtId,
                CheckNumber = c.CheckNumber,
                InvoicingNumber = c.InvoicingNumber,
                AmountBeforeVat = c.AmountBeforeVat,
                AmountAfterVat = c.AmountAfterVat,
                DateOfToday=c.DateOfToday

      
            };
        }
        public static Calculation fromEntityToTbl(EntitiesCalculation c)
        {
            return new Calculation()
            {
                Calculations = c.Calculations,
                ProjectId = c.ProjectId,
                DoubtId = c.DoubtId,
                CheckNumber = c.CheckNumber,
                InvoicingNumber = c.InvoicingNumber,
                AmountBeforeVat = c.AmountBeforeVat,
                AmountAfterVat = c.AmountAfterVat,
                DateOfToday=c.DateOfToday
            };
        }
        public static List<Calculation> LfromEntityToTbl(List<EntitiesCalculation> lc)
        {
            List<Calculation> l = new List<Calculation>();
            foreach (var item in lc)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesCalculation> LfromTblToEntity(List<Calculation> lc)
        {
            List<EntitiesCalculation> l = new List<EntitiesCalculation>();
            foreach (var item in lc)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
   
    }


