using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Contractor
    {
        public int ContractorId { get; set; }
        public int PersonId { get; set; }
        public string ContractorRole { get; set; }
        public string Advertising { get; set; }
        public int CpaId { get; set; }

        public virtual Person Person { get; set; }
    }
}
