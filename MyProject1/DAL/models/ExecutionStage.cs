using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class ExecutionStage
    {
        public int ExecutionStagesId { get; set; }
        public int ProjectId { get; set; }
        public int LevelTypeId { get; set; }
        public int ContractorId { get; set; }
        public DateTime BeginingDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual LevelType LevelType { get; set; }
        public virtual Project Project { get; set; }
    }
}
