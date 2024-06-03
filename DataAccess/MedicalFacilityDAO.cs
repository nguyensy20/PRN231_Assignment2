using Assignment2.Models;
using BussinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MedicalFacilityDAO
    {
        private readonly MyDbContext _context = new();
        public MedicalFacilityDAO()
        {

        }

        public MedicalFacilityDAO(MyDbContext context)
        {
            _context = context;
        }
        public List<MedicalFacility> GetMedicalFacilities()
        {
            try
            {
                var facilities = _context.MedicalFacilities.ToList();
                return facilities;
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<MedicalFacility> GetMedicalFacilitiesByName(string text)
        {
            try
            {
                var facilities = _context.MedicalFacilities.Where(x => x.FacilityName.Trim().ToLower().Contains(text.Trim().ToLower())).ToList();
                return facilities;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public MedicalFacility GetMedicalFacility(int id)
        {
            try
            {
                var facility = _context.MedicalFacilities.FirstOrDefault(x => x.FacilityId == id);
                return facility;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddMedicalFacility(MedicalFacility facility)
        {
            try
            {
                _context.MedicalFacilities.Add(facility);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateMedicalFacility(MedicalFacility facility)
        {
            try
            {
                _context.Entry<MedicalFacility>(facility).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteMedicalFacility(MedicalFacility facility)
        {
            try
            {
                _context.MedicalFacilities.Remove(facility);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
