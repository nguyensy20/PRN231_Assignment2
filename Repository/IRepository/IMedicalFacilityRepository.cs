using Assignment2.Models;
using BussinessObjects.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IMedicalFacilityRepository
    {
        public List<MedicalFacility> GetMedicalFacilities();
        public List<MedicalFacility> GetMedicalFacilitiesByName(string text);
        public MedicalFacility GetMedicalFacility(int id);
        public void AddMediicalFacility(MedicalFacilityDTO request);
        public void UpdateMedicalFacility(MedicalFacility facility);
        public void DeleteMedicalFacility(MedicalFacility facility);
        
    }
}
