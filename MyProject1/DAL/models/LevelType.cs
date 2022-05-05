using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class LevelType
    {
        public LevelType()
        {
            ExecutionStages = new HashSet<ExecutionStage>();
            ProgressSchedules = new HashSet<ProgressSchedule>();
        }

        public int LevelType1 { get; set; }
        public string LevelName { get; set; }

        public virtual ICollection<ExecutionStage> ExecutionStages { get; set; }
        public virtual ICollection<ProgressSchedule> ProgressSchedules { get; set; }
    }
}
