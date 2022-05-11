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
    public class ToolController : ControllerBase
    {

        IBllTool PBll;
        public ToolController(IBllTool p)
        {
            PBll = p;
        }
       
        public List<EntitiesTool> DeleteDalToolsForDay(EntitiesTool t)
        {
            return PBll.DeleteDalToolsForDay(t);
        }

        public List<EntitiesTool> getAll()
        {
            return PBll.getAll();
        }

        public EntitiesTool getById(int id)
        {
            return PBll.getById(id);
        }

        public EntitiesTool getByName(string name)
        {
            return PBll.getByName(name);
        }

        public List<EntitiesTool> PutTool(EntitiesTool t)
        {
            return PBll.PutTool(t);
        }
    }
}
