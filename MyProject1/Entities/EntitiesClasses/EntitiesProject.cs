using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntitiesClasses
{
  public  class EntitiesProject
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Adress { get; set; }
        public DateTime BeginingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
