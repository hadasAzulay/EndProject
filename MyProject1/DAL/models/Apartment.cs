using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Apartment
    {
        public int ApartmentId { get; set; }
        public int ProjectId { get; set; }
        public DateTime KeyGetDate { get; set; }
        public int CostumerId { get; set; }

        public virtual Costumer Costumer { get; set; }
        public virtual Project Project { get; set; }
    }
}
