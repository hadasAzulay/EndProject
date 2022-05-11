using BLL.iClasses;
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
    public class ExecutionStageController : ControllerBase
    {
        IBllExecutionStage bll;
        public ExecutionStageController(IBllExecutionStage Bll)
        {
            bll = Bll;
        }
    }
}
