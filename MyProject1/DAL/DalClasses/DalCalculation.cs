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
            


        }
    }
