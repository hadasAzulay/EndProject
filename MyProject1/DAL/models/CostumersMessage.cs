using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class CostumersMessage
    {
        public int MessageId { get; set; }
        public int ProjectId { get; set; }
        public string Discraption { get; set; }
        public int MessageStatus { get; set; }

        public virtual Project Project { get; set; }
    }
}
