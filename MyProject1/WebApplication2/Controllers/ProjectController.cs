using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.iClasses;
using Entities.EntitiesClasses;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        IBllProjectcs pBll;
            public ProjectController(IBllProjectcs p)
        {
            pBll = p;
        }
        [HttpGet("getAllProjects")]
        public ActionResult<List<EntitiesProject>> getAllProjects()
        {
            return pBll.getAllProjects();
        }
    }
}
