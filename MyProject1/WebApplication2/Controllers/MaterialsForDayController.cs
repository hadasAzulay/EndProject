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
    public class MaterialsForDayController : ControllerBase
    {

        IBllMaterialsForDay bll;
        public MaterialsForDayController(IBllMaterialsForDay Bll)
        {
            bll = Bll;
        }
        public List<EntitiesMaterialsForDay> PutMaterialsForDay(EntitiesMaterialsForDay m)
        {
            return bll.PutMaterialsForDay(m);
        }
        public List<EntitiesMaterialsForDay> deleteMaterialsForDay(EntitiesMaterialsForDay m)
        {
            return bll.deleteMaterialsForDay(m);
        }
        public List<EntitiesMaterialsForDay> getAll()
        {
            return bll.getAll();
        }
    }
}

