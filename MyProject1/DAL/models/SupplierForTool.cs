using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class SupplierForTool
    {
        public int SupplierForTools { get; set; }
        public int SupplierId { get; set; }
        public int ToolId { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Tool Tool { get; set; }
    }
}
