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
    public class CostumersController : ControllerBase
    {

        IBllCostumer bll;
        public CostumersController(IBllCostumer Bll)
        {
            bll = Bll;
        }
        [HttpGet("getByid")]
        public List<EntitiesCostumer> getAll()
        {
            return bll.getAll();
        }
        [HttpPut("putCostumer/{costumer}")]
        public List<EntitiesCostumer> putCostumer(EntitiesCostumer c)
        {
            return bll.putCostumer(c);
        }
    }
}

