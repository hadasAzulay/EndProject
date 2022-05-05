using DAL.models;
using Entities.EntitiesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Converters
{
    class ConvertersProject
    {
        public static EntitiesProject fromTblToEntity(Project p)
        {
            return new EntitiesProject()
            {
               ProjectId=p.ProjectId,
               ProjectName=p.ProjectName,
               Adress=p.Adress,
               BeginingDate=p.BeginingDate,
               EndDate=p.EndDate

            };
        }

        public static Project fromEntityToTbl(EntitiesProject p)
        {
            return new Project()
            {
                ProjectId = p.ProjectId,
                ProjectName = p.ProjectName,
                Adress = p.Adress,
                BeginingDate = p.BeginingDate,
                EndDate = p.EndDate
            };
        }
        public static List<Project> LfromEntityToTbl(List<EntitiesProject> lp)
        {
            List<Project> l = new List<Project>();
            foreach (var item in lp)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesProject> LfromTblToEntity(List<Project> lp)
        {
            List<EntitiesProject> l = new List<EntitiesProject>();
            foreach (var item in lp)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }

    }
}
