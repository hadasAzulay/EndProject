using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersWorker
    {
        public static EntitiesWorker fromTblToEntity(Worker w)
        {
            return new EntitiesWorker()
            {
              WorkerId=w.WorkerId,
              WorkerType=w.WorkerType,
              PersonId=w.PersonId
            };
        }
        public static Worker fromEntityToTbl(EntitiesWorker w)
        {
            return new Worker()
            {
                WorkerId = w.WorkerId,
                WorkerType = w.WorkerType,
                PersonId = w.PersonId
            };
        }
        public static List<Worker> LfromEntityToTbl(List<EntitiesWorker> lw)
        {
            List<Worker> l = new List<Worker>();
            foreach (var item in lw)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesWorker> LfromTblToEntity(List<Worker> lw)
        {
            List<EntitiesWorker> l = new List<EntitiesWorker>();
            foreach (var item in lw)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
