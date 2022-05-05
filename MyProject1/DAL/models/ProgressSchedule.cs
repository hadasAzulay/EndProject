using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class ProgressSchedule
    {
        public int ProgressScheduleId { get; set; }
        public int ProjectId { get; set; }
        public int LevelTypeId { get; set; }
        public DateTime DateOfToday { get; set; }
        public string Discraption { get; set; }

        public virtual LevelType LevelType { get; set; }
        public virtual Project Project { get; set; }
    }
}
