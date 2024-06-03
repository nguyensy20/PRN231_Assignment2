using Assignment2.Models;
using DataAccess;
using Repository.IRepository;

namespace Repository.Repository
{
    public class MedicalFacilityRepository : IMedicalFacilityRepository
    {
        private readonly MedicalFacilityDAO _dao = new MedicalFacilityDAO();

        public void AddMedicalFacility(MedicalFacility facility) => _dao.AddMedicalFacility(facility);
        public void DeleteMedicalFacility(MedicalFacility facility) => _dao.DeleteMedicalFacility(facility);
        public List<MedicalFacility> GetMedicalFacilities() => _dao.GetMedicalFacilities();
        public List<MedicalFacility> GetMedicalFacilitiesByName(string text) => _dao.GetMedicalFacilitiesByName(text);
        public MedicalFacility GetMedicalFacility(int id) => _dao.GetMedicalFacility(id);
        public void UpdateMedicalFacility(MedicalFacility facility) => _dao.UpdateMedicalFacility(facility);
    }
}
