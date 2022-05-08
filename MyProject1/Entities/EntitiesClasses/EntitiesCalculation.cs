using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntitiesClasses
{
    public class EntitiesCalculation
    {
        public int Calculations { get; set; }
        public int ProjectId { get; set; }
        public int DoubtId { get; set; }
        public string CheckNumber { get; set; }
        public string InvoicingNumber { get; set; }
        public double AmountBeforeVat { get; set; }
        public double AmountAfterVat { get; set; }
        public DateTime DateOfToday { get; set; }

    }
}
