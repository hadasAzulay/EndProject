using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Calculation
    {
        public int Calculations { get; set; }
        public int ProjectId { get; set; }
        public int DoubtId { get; set; }
        public string CheckNumber { get; set; }
        public string InvoicingNumber { get; set; }
        public double AmountBeforeVat { get; set; }
        public double AmountAfterVat { get; set; }
        public DateTime DateOfToday { get; set; }

        public virtual Supplier Doubt { get; set; }
        public virtual Project Project { get; set; }
    }
}
