using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class MaterialsForDay
    {
        public MaterialsForDay()
        {
            DailyDiaries = new HashSet<DailyDiary>();
        }

        public int MaterialsForDay1 { get; set; }
        public int DailyDiary { get; set; }
        public int MaterialsId { get; set; }
        public int Amount { get; set; }

        public virtual DailyDiary DailyDiaryNavigation { get; set; }
        public virtual Material Materials { get; set; }
        public virtual ICollection<DailyDiary> DailyDiaries { get; set; }
    }
}
