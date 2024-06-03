using Assignment2.Models;

namespace Repository.IRepository
{
    public interface IMedicalFacilityRepository
    {
        public List<MedicalFacility> GetMedicalFacilities();
        public List<MedicalFacility> GetMedicalFacilitiesByName(string text);
        public MedicalFacility GetMedicalFacility(int id);
        public void AddMedicalFacility(MedicalFacility facility);
        public void UpdateMedicalFacility(MedicalFacility facility);
        public void DeleteMedicalFacility(MedicalFacility facility);
    }
}
