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
    public class MaterialController : ControllerBase
    {
        IBllMaterial bll;
        public MaterialController(IBllMaterial Bll)
        {
            bll = Bll;
        }
        public List<EntitiesMaterial> getAll()
        {
            return bll.getAll();
        }
        public List<EntitiesMaterial> PutMaterial(EntitiesMaterial m)
        {
            return bll.PutMaterial(m);
        }
        public List<EntitiesMaterial> deleteMaterial(EntitiesMaterial m)
        {
            return bll.deleteMaterial(m);
        }

    }
}
