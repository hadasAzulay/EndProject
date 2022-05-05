using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class EquipmentForDay
    {
        public int EquipmentForDay1 { get; set; }
        public int DailyDiary { get; set; }
        public int EquipmentId { get; set; }
        public int Amount { get; set; }

        public virtual Equipment Equipment { get; set; }
    }
}
