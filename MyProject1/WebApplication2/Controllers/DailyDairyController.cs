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
    public class DailyDairyController : ControllerBase
    {
        IBllDailyDairy bll;
        public DailyDairyController(IBllDailyDairy Bll)
        {
            bll = Bll;
        }
        [HttpGet("getAll")]

        public List<EntitiesDailyDairy> getAll()
        {
            return bll.getAll();
        }
        [HttpPut("putDailyDairy/{DailyDairy}")]

        public List<EntitiesDailyDairy> putDailyDairy(EntitiesDailyDairy d)
        {
            return bll.putDailyDairy(d);
        }
        [HttpDelete("deleteDairyDaily/{dailyDairy}")]

        public List<EntitiesDailyDairy> deleteDairyDaily(EntitiesDailyDairy d)
        {
            return bll.deleteDairyDaily(d);
        }
        [HttpGet("GetAlerts/{dailyDairy}")]

        public bool GetAlerts(EntitiesDailyDairy d)
        {
            return bll.GetAlerts(d);

        }
    }
}

