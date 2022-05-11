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
    public class EquipmentForDayController : ControllerBase

    {
        IBllEquipmentForDay bll;
        public EquipmentForDayController(IBllEquipmentForDay Bll)
        {
            bll = Bll;
        }
        public List<EntitiesEquipmentForDay> getAll()
        {
            return bll.getAll();
        }

        public List<EntitiesEquipmentForDay> putEquipmentForDay(EntitiesEquipmentForDay e)
        {
            return bll.putEquipmentForDay(e);
        }
    }
}

