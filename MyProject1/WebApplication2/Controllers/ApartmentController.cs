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
    public class ApartmentController : ControllerBase
    {
        IbllApartment bll;
        public ApartmentController(IbllApartment Bll)
        {
            bll = Bll;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<EntitiesApartment>> getAll()
        {
            return bll.getAll();
        }
        [HttpGet("GetgetAllApartmentsOfPerson/{Id}")]
        public List<EntitiesApartment> getAllApartmentsOfPerson(int pId)
        {
            return bll.getAllApartmentsOfPerson(pId);
        }
        [HttpDelete("deleteApartmentAftYear/{date}")]
        public List<EntitiesApartment> deleteApartmentAftYear(DateTime d)
        {
            return bll.deleteApartmentAftYear(d);
        }

    }
}
