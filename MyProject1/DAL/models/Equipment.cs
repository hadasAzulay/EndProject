using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Equipment
    {
        public Equipment()
        {
            EquipmentForDays = new HashSet<EquipmentForDay>();
        }

        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }

        public virtual ICollection<EquipmentForDay> EquipmentForDays { get; set; }
    }
}
