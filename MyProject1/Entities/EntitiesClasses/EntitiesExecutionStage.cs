using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntitiesClasses
{
  public  class EntitiesExecutionStage
    {
        public int ExecutionStagesId { get; set; }
        public int ProjectId { get; set; }
        public int LevelTypeId { get; set; }
        public int ContractorId { get; set; }
        public DateTime BeginingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
