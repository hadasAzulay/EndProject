using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Calculations = new HashSet<Calculation>();
            EquipmentForTools = new HashSet<EquipmentForTool>();
            MaterialsForTools = new HashSet<MaterialsForTool>();
            SupplierForTools = new HashSet<SupplierForTool>();
        }

        public int DoubtId { get; set; }
        public int PersonId { get; set; }
        public string Advertising { get; set; }
        public int CpaId { get; set; }

        public virtual Person Cpa { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Calculation> Calculations { get; set; }
        public virtual ICollection<EquipmentForTool> EquipmentForTools { get; set; }
        public virtual ICollection<MaterialsForTool> MaterialsForTools { get; set; }
        public virtual ICollection<SupplierForTool> SupplierForTools { get; set; }
    }
}
