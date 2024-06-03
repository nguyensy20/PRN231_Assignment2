using Assignment2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Repository.IRepository;
using Repository.Repository;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MedicalFacilityController : ControllerBase
    {
        private readonly IMedicalFacilityRepository _repo = new MedicalFacilityRepository();

        [HttpGet]
        [EnableQuery]
        public ActionResult<IEnumerable<MedicalFacility>> GetMedicalFacilities() => _repo.GetMedicalFacilities();
    }
}
