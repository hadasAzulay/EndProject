use [finalProject1]

create table People
(
person_id int identity not null,
first_name varchar(50) not null,
last_name varchar(50) not null,
phone_number varchar(50) not null,
email varchar(50) not null,
ps_word varchar(50) not null,
)

create table Workers 
(
worker_id int identity not null,
person_id int not null,
worker_type bit not null
)


create table Costumers 
(
costumers_id int identity not null,
person_id int not null,
apartment_id int not null,
project_id int not null
)


create table Projects
(
project_id int identity not null,
project_name varchar(50) not null,
adress varchar(50) not null,
begining_date date not null,
end_date date not null
)

create table Apartments
(
apartment_id int identity not null,
project_id int not null,
key_get_date date not null
)

create table Execution_Stages /*שלבי ביצוע*/
(
execution_stages_id int identity not null,
project_id int not null,
level_type_id int not null,
contractor_id int not null,
begining_date date not null,
end_date date not null
)

create table Progress_Schedule /*לו"ז התקדמות*/
(
progress_schedule_id int identity not null PRIMARY KEY,
project_id int not null,
level_type_id int not null,
date_of_today date not null,
discraption varchar(max),
)

create table Level_Types
(
level_type int identity not null PRIMARY KEY,
level_name varchar(50) not null
)

create table Daily_Diary
(
daily_diary int identity not null PRIMARY KEY,
project_id int not null,
date_of_today date not null,
details_of_the_work varchar(max) not null,
notes varchar(max), /*הערות*/
begining_hour time not null,
end_hour time not null
)

create table Calculations
(
calculations int identity not null PRIMARY KEY,
project_id int not null,
doubt_id int not null,
check_number varchar(20) not null,
invoicing_number varchar(20) not null, /*מספר חשבונית*/
amount_before_VAT float not null,
amount_after_VAT float not null,/*סכום אחרי מע"מ*/
)

create table Contractors
(
contractor_id int identity not null PRIMARY KEY,
person_id int not null,
contractor_role varchar(20) not null,
advertising varchar(max) not null,/*צריך לשנות את הפרסומת שתהיה אפשרות לנל*/
CPA_id int not null/*קוד רואה חשבון*/
)

create table Doubts
(
doubt_id int identity not null PRIMARY KEY,
person_id int not null,
advertising varchar(max),
CPA_id int not null/*קוד רואה חשבון*/
)

create table Costumers_Message
(
message_id int identity not null PRIMARY KEY,
project_id int not null,
discraption varchar(max) not null,
message_status int not null
)

create table Tools
(
tool_id int identity not null PRIMARY KEY,
tool_name varchar(20) not null
)

create table Equipment
(
equipment_id int identity not null PRIMARY KEY,/*ציוד*/
equipment_name varchar(20) not null
)

create table Materials
(
materials_id int identity not null PRIMARY KEY,/*חומר*/
materials_name varchar(20) not null
)



create table Tools_For_Day
(
Tools_For_Day int identity not null PRIMARY KEY,
daily_diary int not null,
tool_id int  not null,
amount int not null
)


create table Equipment_For_Day
(
equipment_For_Day int identity not null PRIMARY KEY,
daily_diary int not null,
equipment_id int  not null,
amount int not null
)


create table Materials_For_Day
(
materials_For_Day int identity not null PRIMARY KEY,
daily_diary int not null,
materials_id int  not null,
amount int not null
)

create table Doubts_For_Tools
(
doubts_For_Tools int identity not null PRIMARY KEY,
doubt_id int not null,
tool_id int  not null,
)

create table Equipment_For_Tools
(
equipment_For_Tools int identity not null PRIMARY KEY,
doubt_id int not null,
equipment_id int  not null,
)

create table Materials_For_Tools
(
materials_For_Tools int identity not null PRIMARY KEY,
doubt_id int not null,
materials_id int  not null,
)

ALTER TABLE [dbo].[People] ADD  CONSTRAINT [PK_People] PRIMARY KEY (person_id)
ALTER TABLE [dbo].[Workers] ADD  CONSTRAINT [PK_Workers] PRIMARY KEY (worker_id)
ALTER TABLE [dbo].[Costumers] ADD  CONSTRAINT [PK_Costumers] PRIMARY KEY (costumers_id)
ALTER TABLE [dbo].[Projects] ADD  CONSTRAINT [PK_Projects] PRIMARY KEY (project_id)
ALTER TABLE [dbo].[Apartments] ADD  CONSTRAINT [PK_Apartments] PRIMARY KEY (apartment_id)
ALTER TABLE [dbo].[Execution_Stages] ADD  CONSTRAINT [PK_Execution_Stages] PRIMARY KEY (execution_stages_id)

ALTER TABLE [dbo].[Apartments] ADD  CONSTRAINT [FK_ApartmentsToProjects] FOREIGN KEY([project_id])
REFERENCES  [dbo].[Projects]

ALTER TABLE [dbo].[Calculations] ADD  CONSTRAINT [FK_CalculationsoProjects] FOREIGN KEY([project_id])
REFERENCES  [dbo].[Projects]

ALTER TABLE [dbo].[Calculations] ADD  CONSTRAINT [FK_CalculationsToDoubt] FOREIGN KEY([doubt_id])
REFERENCES  [dbo].[Supplier]

ALTER TABLE [dbo].[Costumers] ADD  CONSTRAINT [FK_CostumersTopeople] FOREIGN KEY([person_id])
REFERENCES [dbo].[People]

ALTER TABLE [dbo].[Costumers] ADD  CONSTRAINT [FK_CostumersToApartments] FOREIGN KEY([apartment_id])
REFERENCES [dbo].[Apartments]

ALTER TABLE [dbo].[Costumers] ADD  CONSTRAINT [FK_CostumersToProject] FOREIGN KEY([project_id])
REFERENCES [dbo].[Projects]

ALTER TABLE [dbo].[Costumers_Message] ADD  CONSTRAINT [FK_Costumers_MessageToProject] FOREIGN KEY([project_id])
REFERENCES [dbo].[Projects]

ALTER TABLE [dbo].[Daily_Diary] ADD  CONSTRAINT [FK_Daily_DiaryToProject] FOREIGN KEY([project_id])
REFERENCES [dbo].[Projects]

ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [FK_DoubtsTopeople] FOREIGN KEY([person_id])
REFERENCES [dbo].[People]

ALTER TABLE [dbo].[Supplier]  ADD  CONSTRAINT [FK_CPAToPeople] FOREIGN KEY([CPA_id])
REFERENCES [dbo].[People]

ALTER TABLE [dbo].[Supplier_For_Tools] ADD  CONSTRAINT [FK_Doubts_For_ToolsToDoubt] FOREIGN KEY(supplier_id)
REFERENCES [dbo].[Supplier] 

ALTER TABLE [dbo].[Supplier_For_Tools] ADD  CONSTRAINT [FK_Doubts_For_ToTool] FOREIGN KEY([tool_id])
REFERENCES [dbo].[Tools]

ALTER TABLE [dbo].[Equipment_For_Day] ADD  CONSTRAINT [FK_Equipment_For_DayToDiary] FOREIGN KEY([daily_diary])
REFERENCES [dbo].[Daily_Diary]

ALTER TABLE [dbo].[Equipment_For_Day] ADD  CONSTRAINT [FK_Equipment_For_DayToEquipment] FOREIGN KEY([equipment_id])
REFERENCES [dbo].[Equipment]

ALTER TABLE [dbo].[Equipment_For_Tools] ADD  CONSTRAINT [FK_equipment_For_ToolsToDoubt] FOREIGN KEY([doubt_id])
REFERENCES [dbo].[Supplier]

ALTER TABLE [dbo].[Equipment_For_Tools] ADD  CONSTRAINT [FK_equipment_For_ToolsToEquipment] FOREIGN KEY([equipment_id])
REFERENCES [dbo].[Equipment]

ALTER TABLE [dbo].[Execution_Stages]  ADD  CONSTRAINT [FK_Execution_StagesToProject] FOREIGN KEY([project_id])
REFERENCES [dbo].[Projects]

ALTER TABLE [dbo].[Execution_Stages]  ADD  CONSTRAINT [FK_Execution_StagesToLevelType] FOREIGN KEY([level_type_id])
REFERENCES [dbo].[Level_Types]

ALTER TABLE [dbo].[Execution_Stages]  ADD  CONSTRAINT [FK_Execution_StagesToContractor] FOREIGN KEY([contractor_id])
REFERENCES [dbo].[Contractors]

ALTER TABLE [dbo].[Materials_For_Day] ADD  CONSTRAINT [FK_Materials_For_DayTodiary] FOREIGN KEY([daily_diary])
REFERENCES [dbo].[Daily_Diary]

ALTER TABLE [dbo].[Materials_For_Day] ADD  CONSTRAINT [FK_Materials_For_DayToMaterials] FOREIGN KEY([materials_id])
REFERENCES [dbo].[Materials]

ALTER TABLE [dbo].[Materials_For_Tools] ADD  CONSTRAINT [FK_Materials_For_ToolsToDoubt] FOREIGN KEY([doubt_id])
REFERENCES [dbo].[Supplier]

ALTER TABLE [dbo].[Materials_For_Tools] ADD  CONSTRAINT [FK_Materials_For_ToolsToMaterials] FOREIGN KEY([materials_id])
REFERENCES [dbo].[Materials]

ALTER TABLE [dbo].[Progress_Schedule] ADD  CONSTRAINT [FK_Progress_ScheduleToProject] FOREIGN KEY([project_id])
REFERENCES [dbo].[Projects]

ALTER TABLE [dbo].[Progress_Schedule] ADD  CONSTRAINT [FK_Progress_ScheduleToLevelType] FOREIGN KEY([level_type_id])
REFERENCES [dbo].[Level_Types]

ALTER TABLE [dbo].[Tools_For_Day] ADD  CONSTRAINT [FK_Tools_For_DayToDiary] FOREIGN KEY([daily_diary])
REFERENCES [dbo].[Daily_Diary]

ALTER TABLE [dbo].[Tools_For_Day] ADD  CONSTRAINT [FK_Tools_For_DayToTool] FOREIGN KEY([tool_id])
REFERENCES [dbo].[Tools]

ALTER TABLE [dbo].[Workers] ADD  CONSTRAINT [FK_WorkersToPeople] FOREIGN KEY([worker_id])
REFERENCES [dbo].[People]

ALTER TABLE [dbo].[Apartments] ADD costumer_id int not null
ALTER TABLE [dbo].[Costumers] DROP  CONSTRAINT [FK_CostumersToApartments]

ALTER TABLE [dbo].[Apartments] ADD  CONSTRAINT [FK_ApartmentsToCostumers] FOREIGN KEY([costumer_id])
REFERENCES  [dbo].[Costumers]




 











