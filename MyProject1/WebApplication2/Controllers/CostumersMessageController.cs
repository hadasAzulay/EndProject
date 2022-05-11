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
    public class CostumersMessageController : ControllerBase
    {

        IBllCostumersMessage bll;
        public CostumersMessageController(IBllCostumersMessage Bll)
        {
            bll = Bll;
        }
    }
}
