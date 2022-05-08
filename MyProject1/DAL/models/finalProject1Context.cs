using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.models
{
    public partial class finalProject1Context : DbContext
    {
        public finalProject1Context()
        {
        }

        public finalProject1Context(DbContextOptions<finalProject1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Calculation> Calculations { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<Costumer> Costumers { get; set; }
        public virtual DbSet<CostumersMessage> CostumersMessages { get; set; }
        public virtual DbSet<Cpa> Cpas { get; set; }
        public virtual DbSet<DailyDiary> DailyDiaries { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentForDay> EquipmentForDays { get; set; }
        public virtual DbSet<EquipmentForTool> EquipmentForTools { get; set; }
        public virtual DbSet<ExecutionStage> ExecutionStages { get; set; }
        public virtual DbSet<LevelType> LevelTypes { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialsForDay> MaterialsForDays { get; set; }
        public virtual DbSet<MaterialsForTool> MaterialsForTools { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<ProgressSchedule> ProgressSchedules { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierForTool> SupplierForTools { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<ToolsForDay> ToolsForDays { get; set; }
        public virtual DbSet<TypesOfProject> TypesOfProjects { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=finalProject1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Apartment>(entity =>
            {
                entity.Property(e => e.ApartmentId).HasColumnName("apartment_id");

                entity.Property(e => e.CostumerId).HasColumnName("costumer_id");

                entity.Property(e => e.KeyGetDate)
                    .HasColumnType("date")
                    .HasColumnName("key_get_date");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Costumer)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.CostumerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApartmentsToCostumers");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApartmentsToProjects");
            });

            modelBuilder.Entity<Calculation>(entity =>
            {
                entity.HasKey(e => e.Calculations)
                    .HasName("PK__Calculat__0254B60780BA47C9");

                entity.Property(e => e.Calculations).HasColumnName("calculations");

                entity.Property(e => e.AmountAfterVat).HasColumnName("amount_after_VAT");

                entity.Property(e => e.AmountBeforeVat).HasColumnName("amount_before_VAT");

                entity.Property(e => e.CheckNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("check_number");

                entity.Property(e => e.DateOfToday)
                    .HasColumnType("date")
                    .HasColumnName("date_of_today");

                entity.Property(e => e.DoubtId).HasColumnName("doubt_id");

                entity.Property(e => e.InvoicingNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("invoicing_number");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Doubt)
                    .WithMany(p => p.Calculations)
                    .HasForeignKey(d => d.DoubtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CalculationsToDoubt");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Calculations)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CalculationsoProjects");
            });

            modelBuilder.Entity<Contractor>(entity =>
            {
                entity.Property(e => e.ContractorId).HasColumnName("contractor_id");

                entity.Property(e => e.Advertising)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("advertising");

                entity.Property(e => e.ContractorRole)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contractor_role");

                entity.Property(e => e.CpaId).HasColumnName("CPA_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Contractors)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contractors_People");
            });

            modelBuilder.Entity<Costumer>(entity =>
            {
                entity.HasKey(e => e.CostumersId);

                entity.Property(e => e.CostumersId).HasColumnName("costumers_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Costumers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostumersTopeople");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Costumers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostumersToProject");
            });

            modelBuilder.Entity<CostumersMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__Costumer__0BBF6EE6BD199285");

                entity.ToTable("Costumers_Message");

                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.Property(e => e.Discraption)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("discraption");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CostumersMessages)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Costumers_MessageToProject");
            });

            modelBuilder.Entity<Cpa>(entity =>
            {
                entity.ToTable("CPA");

                entity.Property(e => e.CpaId).HasColumnName("CPA_id");

                entity.Property(e => e.PersonId).HasColumnName("Person_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Cpas)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPAsToPeople");
            });

            modelBuilder.Entity<DailyDiary>(entity =>
            {
                entity.HasKey(e => e.DailyDiary1)
                    .HasName("PK__Daily_Di__BC36A40446D41B5B");

                entity.ToTable("Daily_Diary");

                entity.Property(e => e.DailyDiary1).HasColumnName("daily_diary");

                entity.Property(e => e.BeginingHour).HasColumnName("begining_hour");

                entity.Property(e => e.DateOfToday)
                    .HasColumnType("date")
                    .HasColumnName("date_of_today");

                entity.Property(e => e.DetailsOfTheWork)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("details_of_the_work");

                entity.Property(e => e.EndHour).HasColumnName("end_hour");

                entity.Property(e => e.Notes)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DailyDiaries)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_DiaryToProject");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("equipment_name");
            });

            modelBuilder.Entity<EquipmentForDay>(entity =>
            {
                entity.HasKey(e => e.EquipmentForDay1)
                    .HasName("PK__Equipmen__460E9F75301E2A77");

                entity.ToTable("Equipment_For_Day");

                entity.Property(e => e.EquipmentForDay1).HasColumnName("equipment_For_Day");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DailyDiary).HasColumnName("daily_diary");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.EquipmentForDays)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_For_Day_Equipment");
            });

            modelBuilder.Entity<EquipmentForTool>(entity =>
            {
                entity.HasKey(e => e.EquipmentForTools)
                    .HasName("PK__Equipmen__0FCAE9C2AE82DEB8");

                entity.ToTable("Equipment_For_Tools");

                entity.Property(e => e.EquipmentForTools).HasColumnName("equipment_For_Tools");

                entity.Property(e => e.DoubtId).HasColumnName("doubt_id");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.HasOne(d => d.Doubt)
                    .WithMany(p => p.EquipmentForTools)
                    .HasForeignKey(d => d.DoubtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_equipment_For_ToolsToDoubt");
            });

            modelBuilder.Entity<ExecutionStage>(entity =>
            {
                entity.HasKey(e => e.ExecutionStagesId);

                entity.ToTable("Execution_Stages");

                entity.Property(e => e.ExecutionStagesId).HasColumnName("execution_stages_id");

                entity.Property(e => e.BeginingDate)
                    .HasColumnType("date")
                    .HasColumnName("begining_date");

                entity.Property(e => e.ContractorId).HasColumnName("contractor_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.LevelTypeId).HasColumnName("level_type_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.LevelType)
                    .WithMany(p => p.ExecutionStages)
                    .HasForeignKey(d => d.LevelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Execution_StagesToLevelType");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ExecutionStages)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Execution_StagesToProject");
            });

            modelBuilder.Entity<LevelType>(entity =>
            {
                entity.HasKey(e => e.LevelType1)
                    .HasName("PK__Level_Ty__186F356CCAF6AFC8");

                entity.ToTable("Level_Types");

                entity.Property(e => e.LevelType1).HasColumnName("level_type");

                entity.Property(e => e.LevelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("level_name");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.MaterialsId)
                    .HasName("PK__Material__73E2DA8A3391506C");

                entity.Property(e => e.MaterialsId).HasColumnName("materials_id");

                entity.Property(e => e.MaterialsName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("materials_name");
            });

            modelBuilder.Entity<MaterialsForDay>(entity =>
            {
                entity.HasKey(e => e.MaterialsForDay1)
                    .HasName("PK__Material__B162383E5CAF2B8D");

                entity.ToTable("Materials_For_Day");

                entity.Property(e => e.MaterialsForDay1).HasColumnName("materials_For_Day");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DailyDiary).HasColumnName("daily_diary");

                entity.Property(e => e.MaterialsId).HasColumnName("materials_id");

                entity.HasOne(d => d.DailyDiaryNavigation)
                    .WithMany(p => p.MaterialsForDays)
                    .HasForeignKey(d => d.DailyDiary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Materials_For_DayTodiary");

                entity.HasOne(d => d.Materials)
                    .WithMany(p => p.MaterialsForDays)
                    .HasForeignKey(d => d.MaterialsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Materials_For_DayToMaterials");
            });

            modelBuilder.Entity<MaterialsForTool>(entity =>
            {
                entity.HasKey(e => e.MaterialsForTools)
                    .HasName("PK__Material__B9D2BA9824F8218F");

                entity.ToTable("Materials_For_Tools");

                entity.Property(e => e.MaterialsForTools).HasColumnName("materials_For_Tools");

                entity.Property(e => e.DoubtId).HasColumnName("doubt_id");

                entity.Property(e => e.MaterialsId).HasColumnName("materials_id");

                entity.HasOne(d => d.Doubt)
                    .WithMany(p => p.MaterialsForTools)
                    .HasForeignKey(d => d.DoubtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Materials_For_ToolsToDoubt");

                entity.HasOne(d => d.Materials)
                    .WithMany(p => p.MaterialsForTools)
                    .HasForeignKey(d => d.MaterialsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Materials_For_ToolsToMaterials");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.PsWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ps_word");
            });

            modelBuilder.Entity<ProgressSchedule>(entity =>
            {
                entity.ToTable("Progress_Schedule");

                entity.Property(e => e.ProgressScheduleId).HasColumnName("progress_schedule_id");

                entity.Property(e => e.DateOfToday)
                    .HasColumnType("date")
                    .HasColumnName("date_of_today");

                entity.Property(e => e.Discraption)
                    .IsUnicode(false)
                    .HasColumnName("discraption");

                entity.Property(e => e.LevelTypeId).HasColumnName("level_type_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.LevelType)
                    .WithMany(p => p.ProgressSchedules)
                    .HasForeignKey(d => d.LevelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Progress_ScheduleToLevelType");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProgressSchedules)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Progress_ScheduleToProject");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.BeginingDate)
                    .HasColumnType("date")
                    .HasColumnName("begining_date");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("project_name");

                entity.Property(e => e.TypeOfProjects).HasColumnName("typeOfProjects");

                entity.HasOne(d => d.TypeOfProjectsNavigation)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.TypeOfProjects)
                    .HasConstraintName("FK_ProjectsToTypeProjects");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.DoubtId)
                    .HasName("PK__Doubts__7561E95FE98B3A5B");

                entity.ToTable("Supplier");

                entity.Property(e => e.DoubtId).HasColumnName("doubt_id");

                entity.Property(e => e.Advertising)
                    .IsUnicode(false)
                    .HasColumnName("advertising");

                entity.Property(e => e.CpaId).HasColumnName("CPA_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.Cpa)
                    .WithMany(p => p.SupplierCpas)
                    .HasForeignKey(d => d.CpaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPAToPeople");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SupplierPeople)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoubtsTopeople");
            });

            modelBuilder.Entity<SupplierForTool>(entity =>
            {
                entity.HasKey(e => e.SupplierForTools)
                    .HasName("PK__Doubts_F__64BD4714F07B4687");

                entity.ToTable("Supplier_For_Tools");

                entity.Property(e => e.SupplierForTools).HasColumnName("supplier_For_Tools");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.ToolId).HasColumnName("tool_id");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierForTools)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doubts_For_ToolsToDoubt");

                entity.HasOne(d => d.Tool)
                    .WithMany(p => p.SupplierForTools)
                    .HasForeignKey(d => d.ToolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doubts_For_ToTool");
            });

            modelBuilder.Entity<Tool>(entity =>
            {
                entity.Property(e => e.ToolId).HasColumnName("tool_id");

                entity.Property(e => e.ToolName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tool_name");
            });

            modelBuilder.Entity<ToolsForDay>(entity =>
            {
                entity.HasKey(e => e.ToolsForDay1)
                    .HasName("PK__Tools_Fo__BCDEAFEABD0A0863");

                entity.ToTable("Tools_For_Day");

                entity.Property(e => e.ToolsForDay1).HasColumnName("Tools_For_Day");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DailyDiary).HasColumnName("daily_diary");

                entity.Property(e => e.ToolId).HasColumnName("tool_id");

                entity.HasOne(d => d.DailyDiaryNavigation)
                    .WithMany(p => p.ToolsForDays)
                    .HasForeignKey(d => d.DailyDiary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tools_For_DayToDiary");

                entity.HasOne(d => d.Tool)
                    .WithMany(p => p.ToolsForDays)
                    .HasForeignKey(d => d.ToolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tools_For_DayToTool");
            });

            modelBuilder.Entity<TypesOfProject>(entity =>
            {
                entity.HasKey(e => e.TypesOfProjects)
                    .HasName("PK__Types_Of__3C69814421989184");

                entity.ToTable("Types_Of_Projects");

                entity.Property(e => e.TypesOfProjects).HasColumnName("Types_Of_Projects");

                entity.Property(e => e.TypeProjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Type_Project_Name");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.Property(e => e.WorkerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("worker_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.WorkerType).HasColumnName("worker_type");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.WorkerPeople)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workers_People");

                entity.HasOne(d => d.WorkerNavigation)
                    .WithOne(p => p.WorkerWorkerNavigation)
                    .HasForeignKey<Worker>(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkersToPeople");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
