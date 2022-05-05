using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Costumer
    {
        public Costumer()
        {
            Apartments = new HashSet<Apartment>();
        }

        public int CostumersId { get; set; }
        public int PersonId { get; set; }
        public int ProjectId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
