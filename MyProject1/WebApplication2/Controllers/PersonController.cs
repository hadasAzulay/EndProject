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
    [Route("api/[Controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IBllPerson PBll;
        public PersonController(IBllPerson p)
        {
            PBll = p;
        }
        [HttpGet("GetAllPerson")]
        public ActionResult<List<EntitiesPerson>> getAll()
        {
            return PBll.getAll();
        }
        [HttpPut("putPerson/{person}")]
        public List<EntitiesPerson> putPerson(EntitiesPerson p)
        {
            return PBll.putPerson(p);
        }
        [HttpGet("getPersonByEmailAndPas/{email}/{pass}")]

        public EntitiesPerson getPersonByEmailAndPas(string email, string pass)
        {
            return PBll.getPersonByEmailAndPas(email,pass);
        }
        public List<EntitiesPerson> updatePerson(EntitiesPerson p)
        {
            return PBll.updatePerson(p);
        }
    }
}
