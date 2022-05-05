using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntitiesClasses
{
   public class EntitiesProgressSchedule
    {
        public int ProgressScheduleId { get; set; }
        public int ProjectId { get; set; }
        public int LevelTypeId { get; set; }
        public DateTime DateOfToday { get; set; }
        public string Discraption { get; set; }
    }
}
