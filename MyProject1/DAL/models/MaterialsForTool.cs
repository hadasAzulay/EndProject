using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class MaterialsForTool
    {
        public int MaterialsForTools { get; set; }
        public int DoubtId { get; set; }
        public int MaterialsId { get; set; }

        public virtual Supplier Doubt { get; set; }
        public virtual Material Materials { get; set; }
    }
}
