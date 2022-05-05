using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Doubt
    {
        public int DoubtId { get; set; }
        public int PersonId { get; set; }
        public string Advertising { get; set; }
        public int CpaId { get; set; }
    }
}
