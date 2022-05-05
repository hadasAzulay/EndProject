using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Tool
    {
        public Tool()
        {
            SupplierForTools = new HashSet<SupplierForTool>();
            ToolsForDays = new HashSet<ToolsForDay>();
        }

        public int ToolId { get; set; }
        public string ToolName { get; set; }

        public virtual ICollection<SupplierForTool> SupplierForTools { get; set; }
        public virtual ICollection<ToolsForDay> ToolsForDays { get; set; }
    }
}
