using Assignment2.Models;
using BussinessObjects;
using BussinessObjects.DTOs;
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
        private readonly MyDbContext _context = new();

        [HttpGet]
        [EnableQuery]
        public ActionResult<IEnumerable<MedicalFacility>> GetMedicalFacilities() => _repo.GetMedicalFacilities();

        [HttpGet]
        [EnableQuery]
        public ActionResult<MedicalFacility> GetMedicalFacility(int id) => _repo.GetMedicalFacility(id);

        [HttpPost]
        public IActionResult AddMedicalFacility(MedicalFacilityDTO request)
        {
            var facility = new MedicalFacility
            {
                FacilityName = request.FacilityName,
                NoDoctors = request.NoDoctors,
                NoStaffs = request.NoStaffs,
                PrivateFacility = request.PrivateFacility,
                Level = request.Level
            };

            if (string.IsNullOrEmpty(facility.FacilityName))
            {
                return StatusCode(400, "FacilityName is required!");
            }

            else if (facility.NoDoctors < 0)
            {
                return StatusCode(400, "NoDoctors must be greater than 0!");
            }

            else if (facility.NoStaffs < 0)
            {
                return StatusCode(400, "NoStaffs must be greater than 0!");
            }

            else if (facility.Level < 1 || facility.Level > 5)
            {
                return StatusCode(400, "Level must be in range [1-5]!");
            }

            else
            {
                _repo.AddMedicalFacility(facility);
                return NoContent();
            }
        }
    }
}
