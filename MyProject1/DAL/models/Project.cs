using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Project
    {
        public Project()
        {
            Apartments = new HashSet<Apartment>();
            Calculations = new HashSet<Calculation>();
            Costumers = new HashSet<Costumer>();
            CostumersMessages = new HashSet<CostumersMessage>();
            DailyDiaries = new HashSet<DailyDiary>();
            ExecutionStages = new HashSet<ExecutionStage>();
            ProgressSchedules = new HashSet<ProgressSchedule>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Adress { get; set; }
        public DateTime BeginingDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? TypeOfProjects { get; set; }

        public virtual TypesOfProject TypeOfProjectsNavigation { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<Calculation> Calculations { get; set; }
        public virtual ICollection<Costumer> Costumers { get; set; }
        public virtual ICollection<CostumersMessage> CostumersMessages { get; set; }
        public virtual ICollection<DailyDiary> DailyDiaries { get; set; }
        public virtual ICollection<ExecutionStage> ExecutionStages { get; set; }
        public virtual ICollection<ProgressSchedule> ProgressSchedules { get; set; }
    }
}
