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
    public class ToolForDayController : ControllerBase
    {

        IBllToolForDay PBll;
        public ToolForDayController(IBllToolForDay p)
        {
            PBll = p;
        }
        public List<EntitiesToolsForDay> DeleteDalToolsForDay(EntitiesToolsForDay t)
        {
            return PBll.DeleteDalToolsForDay(t);
        }

        public List<EntitiesToolsForDay> getAll()
        {
            return PBll.getAll();
        }

        public List<EntitiesToolsForDay> PutDalToolsForDay(EntitiesToolsForDay t)
        {
            return PBll.PutDalToolsForDay(t);
        }
    }
}
