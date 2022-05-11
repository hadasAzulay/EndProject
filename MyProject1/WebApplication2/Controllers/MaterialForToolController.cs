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
    public class MaterialForToolController : ControllerBase
    {
        IBllMaterialForTool bll;
        public MaterialForToolController(IBllMaterialForTool Bll)
        {
            bll = Bll;
        }
    }
}
