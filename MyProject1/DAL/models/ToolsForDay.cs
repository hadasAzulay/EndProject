using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class ToolsForDay
    {
        public ToolsForDay()
        {
            DailyDiaries = new HashSet<DailyDiary>();
        }

        public int ToolsForDay1 { get; set; }
        public int DailyDiary { get; set; }
        public int ToolId { get; set; }
        public int Amount { get; set; }

        public virtual DailyDiary DailyDiaryNavigation { get; set; }
        public virtual Tool Tool { get; set; }
        public virtual ICollection<DailyDiary> DailyDiaries { get; set; }
    }
}
