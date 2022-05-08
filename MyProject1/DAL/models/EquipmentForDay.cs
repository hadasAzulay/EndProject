using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class EquipmentForDay
    {
        public EquipmentForDay()
        {
            DailyDiaries = new HashSet<DailyDiary>();
        }

        public int EquipmentForDay1 { get; set; }
        public int DailyDiary { get; set; }
        public int EquipmentId { get; set; }
        public int Amount { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual ICollection<DailyDiary> DailyDiaries { get; set; }
    }
}
