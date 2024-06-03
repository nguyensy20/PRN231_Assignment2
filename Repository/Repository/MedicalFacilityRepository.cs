using Assignment2.Models;
using BussinessObjects.DTOs;
using DataAccess;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class MedicalFacilityRepository : IMedicalFacilityRepository
    {
        private readonly MedicalFacilityDAO _dao = new MedicalFacilityDAO();

        public void AddMediicalFacility(MedicalFacilityDTO request) => _dao.AddMediicalFacility(request);
        public void DeleteMedicalFacility(MedicalFacility facility) => _dao.DeleteMedicalFacility(facility);
        public List<MedicalFacility> GetMedicalFacilities() => _dao.GetMedicalFacilities();
        public List<MedicalFacility> GetMedicalFacilitiesByName(string text) => _dao.GetMedicalFacilitiesByName(text);
        public MedicalFacility GetMedicalFacility(int id) => _dao.GetMedicalFacility(id);
        public void UpdateMedicalFacility(MedicalFacility facility) => _dao.UpdateMedicalFacility(facility);
    }
}
