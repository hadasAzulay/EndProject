using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class DailyDiary
    {
        public DailyDiary()
        {
            MaterialsForDays = new HashSet<MaterialsForDay>();
            ToolsForDays = new HashSet<ToolsForDay>();
        }

        public int DailyDiary1 { get; set; }
        public int ProjectId { get; set; }
        public DateTime DateOfToday { get; set; }
        public string DetailsOfTheWork { get; set; }
        public string Notes { get; set; }
        public TimeSpan BeginingHour { get; set; }
        public TimeSpan EndHour { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<MaterialsForDay> MaterialsForDays { get; set; }
        public virtual ICollection<ToolsForDay> ToolsForDays { get; set; }
    }
}
