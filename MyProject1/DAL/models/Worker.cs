using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Worker
    {
        public int WorkerId { get; set; }
        public int PersonId { get; set; }
        public bool WorkerType { get; set; }

        public virtual Person Person { get; set; }
        public virtual Person WorkerNavigation { get; set; }
    }
}
