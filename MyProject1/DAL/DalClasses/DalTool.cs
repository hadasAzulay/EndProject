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
 public class DalTool: IDalTool
    {
        finalProject1Context db;
        public DalTool(finalProject1Context DB)
        {
            db = DB;
        }
        //Add
        public List<EntitiesTool> PutTool(EntitiesTool t)
        {
            db.Tools.Add(ConvertersTool.fromEntityToTbl(t));
            db.SaveChanges();
            return getAll() ;
        }
        //delete

        public List<EntitiesTool> DeleteDalToolsForDay(EntitiesTool t)
        {
            db.Tools.Remove(ConvertersTool.fromEntityToTbl(t));
            db.SaveChanges();
            return getAll();
        }
        //getbyName

        public EntitiesTool getByName(string name) 
        {
            Tool t = db.Tools.FirstOrDefault(x => x.ToolName == name);
            if (t != null)
                return ConvertersTool.fromTblToEntity(t);
            return null;
        }
        //getbyID

        public EntitiesTool getById(int id)
        {
            Tool t = db.Tools.FirstOrDefault(x => x.ToolId == id);
            if (t != null)
                return ConvertersTool.fromTblToEntity(t);
            return null;
        }
        //getAll

        public List<EntitiesTool> getAll()
        {
            return ConvertersTool.LfromTblToEntity(db.Tools.ToList());
        }
    }

}

