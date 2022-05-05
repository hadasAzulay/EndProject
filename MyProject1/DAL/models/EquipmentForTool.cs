using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class EquipmentForTool
    {
        public int EquipmentForTools { get; set; }
        public int DoubtId { get; set; }
        public int EquipmentId { get; set; }

        public virtual Supplier Doubt { get; set; }
    }
}
