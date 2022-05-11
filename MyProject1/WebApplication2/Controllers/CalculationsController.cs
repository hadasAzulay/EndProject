using BLL.iClasses;
using Entities.EntitiesClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        IBllCalculation bll;
        public CalculationsController(IBllCalculation Bll)
        {
            bll = Bll;
        }
        [HttpGet("GetAll")]
        public List<EntitiesCalculation> getAll()
        {
            return bll.getAll();
        }
        [HttpGet("GetCalculationsOfProject/{proId}")]
        public List<EntitiesCalculation> GetCalculationsOfProject(int proId)
        {
            return bll.GetCalculationsOfProject(proId);
        }
        [HttpGet("GetCalculationsBySupp/{supplierId}")]
        public List<EntitiesCalculation> GetCalculationsBySupp(int supplierID)
        {
            return bll.GetCalculationsBySupp(supplierID);
        }
        [HttpGet("GetCalculationbyCheckNu/{numberCheck}")]
        public EntitiesCalculation GetCalculationbyCheckNu(string NumberCheck)
        {
            return bll.GetCalculationbyCheckNu(NumberCheck);
        }
        [HttpPut("putCalculation/{calaulation}")]
        public List<EntitiesCalculation> putCalculation(EntitiesCalculation c) 
        {
            return bll.putCalculation(c);
        }
        [HttpGet("GetCalculationbyDate/{date}")]
        public EntitiesCalculation GetCalculationbyDate(DateTime d)
        {
            return bll.GetCalculationbyDate(d);
        }
    }
    }

