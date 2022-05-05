using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Material
    {
        public Material()
        {
            MaterialsForDays = new HashSet<MaterialsForDay>();
            MaterialsForTools = new HashSet<MaterialsForTool>();
        }

        public int MaterialsId { get; set; }
        public string MaterialsName { get; set; }

        public virtual ICollection<MaterialsForDay> MaterialsForDays { get; set; }
        public virtual ICollection<MaterialsForTool> MaterialsForTools { get; set; }
    }
}
