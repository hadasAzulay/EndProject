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
    public class EquipmentController : ControllerBase
    {
            IBllEquipment bll;
            public EquipmentController(IBllEquipment Bll)
            {
                bll = Bll;
            }
            public List<EntitiesEquipment> PutEquipment(EntitiesEquipment t)
        {
            return bll.PutEquipment(t);
        }
        public List<EntitiesEquipment> DeleteEquipment(EntitiesEquipment t)
        {
            return bll.DeleteEquipment(t);
        }
        public List<EntitiesEquipment> getAll()
        {
            return bll.getAll();
        }
    }
}
