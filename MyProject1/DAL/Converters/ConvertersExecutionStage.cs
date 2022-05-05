using System;
using System.Collections.Generic;
using System.Text;
using DAL.models;
using Entities.EntitiesClasses;

namespace DAL.Converters
{
    class ConvertersExecutionStage
    {
        public static EntitiesExecutionStage fromTblToEntity(ExecutionStage e)
        {
            return new EntitiesExecutionStage()
            {
                ExecutionStagesId=e.ExecutionStagesId,
                ProjectId=e.ProjectId,
                LevelTypeId=e.LevelTypeId,
                ContractorId=e.ContractorId,
                BeginingDate=e.BeginingDate,
                EndDate = e.EndDate
            };
        }
        public static ExecutionStage fromEntityToTbl(EntitiesExecutionStage e)
        {
            return new ExecutionStage()
            {
                ExecutionStagesId = e.ExecutionStagesId,
                ProjectId = e.ProjectId,
                LevelTypeId = e.LevelTypeId,
                ContractorId = e.ContractorId,
                BeginingDate = e.BeginingDate,
                EndDate = e.EndDate
            };
        }
        public static List<ExecutionStage> LfromEntityToTbl(List<EntitiesExecutionStage> le)
        {
            List<ExecutionStage> l = new List<ExecutionStage>();
            foreach (var item in le)
            {
                l.Add(fromEntityToTbl(item));
            }
            return l;
        }
        public static List<EntitiesExecutionStage> LfromTblToEntity(List<ExecutionStage> le)
        {
            List<EntitiesExecutionStage> l = new List<EntitiesExecutionStage>();
            foreach (var item in le)
            {
                l.Add(fromTblToEntity(item));
            }
            return l;
        }
    }
}
