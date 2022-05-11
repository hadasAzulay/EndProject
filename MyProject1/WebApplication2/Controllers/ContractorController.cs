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
    public class ContractorController : ControllerBase
    {
        IBllContractor bll;
        public ContractorController(IBllContractor Bll)
        {
            bll = Bll;
        }
        [HttpGet("getByid/{id}")]
        public EntitiesContractor getByid(int id)
        {
            return bll.getByid(id);
        }
        [HttpGet("getByEmail/{Email}")]
        public EntitiesContractor getByEmail(string Email)
        {
            return bll.getByEmail(Email);
        }
        [HttpGet("getByPhone/{PhoneNumber}")]
        public EntitiesContractor getByPhone(string PhoneNumber)
        {
            return bll.getByPhone(PhoneNumber);
        }
        [HttpDelete("deleteContractor/{contractor}")]
        public List<EntitiesContractor> deleteContractor(EntitiesContractor c)
        {
            return bll.deleteContractor(c);
        }
        [HttpPut("PutContractor/{contractor}")]
        public List<EntitiesContractor> PutContractor(EntitiesContractor c)
        {
            return bll.deleteContractor(c);
        }
        [HttpGet("getAll")]
        public List<EntitiesContractor> getAll()
        {
            return bll.getAll();
        }
    }
}
