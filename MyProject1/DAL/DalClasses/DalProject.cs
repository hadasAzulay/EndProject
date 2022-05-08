using DAL.Converters;
using DAL.DaliClasses;
using DAL.models;
using Entities.EntitiesClasses;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DalClasses
{
    public class DalProject : IDalProjects
    {
        finalProject1Context db;
        public DalProject(finalProject1Context DB)
        {
            db = DB;
        }
        public List<EntitiesProject> getAllProjects()
        {
            return ConvertersProject.LfromTblToEntity(db.Projects.ToList());
        }
        public List<EntitiesProject> putProject(EntitiesProject p)
        {
            db.Projects.Add(ConvertersProject.fromEntityToTbl(p));
            db.SaveChanges();
            return getAllProjects();
        }
        public List<EntitiesProject> getProjectsByType(int id)
        {
            List<EntitiesProject> lp = new List<EntitiesProject>();
            foreach(var item in db.Projects)
            {
                Project p = db.Projects.FirstOrDefault(x => x.TypeOfProjects == id);
                lp.Add(ConvertersProject.fromTblToEntity(p));
            }
            return (lp);
        }
        
        }
}
