using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.iClasses;
using Entities.EntitiesClasses;

namespace MyProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IBllPerson PBll;
        public PersonController(IBllPerson p)
        {
            PBll = p;
        }
        [HttpGet ("GetAllPerson")]
        public ActionResult< List<EntitiesPerson>> getAll()
        {
            return PBll.getAll();
        }

    }
}
