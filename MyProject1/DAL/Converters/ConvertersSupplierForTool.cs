using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersSupplierForTool
    {
        public static EntitiesSupplierForTool fromTblToEntity(SupplierForTool s)
        {
            return new EntitiesSupplierForTool()
            {
                SupplierId = s.SupplierId,
                ToolId = s.ToolId,
                SupplierForTools = s.SupplierForTools
            };
        }
        public static SupplierForTool fromEntityToTbl(EntitiesSupplierForTool s)
        {
            return new SupplierForTool()
            {
          SupplierId=s.SupplierId,
          ToolId=s.ToolId,
          SupplierForTools=s.SupplierForTools
            };
        }
        public static List<SupplierForTool> LfromEntityToTbl(List<EntitiesSupplierForTool> ls)
        {
            List<SupplierForTool> l = new List<SupplierForTool>();
            foreach (var item in ls)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesSupplierForTool> LfromTblToEntity(List<SupplierForTool> ls)
        {
            List<EntitiesSupplierForTool> l = new List<EntitiesSupplierForTool>();
            foreach (var item in ls)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
