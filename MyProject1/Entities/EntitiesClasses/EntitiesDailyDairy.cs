using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntitiesClasses
{
 public   class EntitiesDailyDairy
    {

        public int DailyDiary1 { get; set; }
        public int ProjectId { get; set; }
        public DateTime DateOfToday { get; set; }
        public string DetailsOfTheWork { get; set; }
        public string Notes { get; set; }
        public TimeSpan BeginingHour { get; set; }
        public TimeSpan EndHour { get; set; }


    }
}
