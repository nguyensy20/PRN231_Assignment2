using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.DTOs
{
    public class MedicalFacilityDTO
    {
        public string FacilityName { get; set; }
        public int NoDoctors { get; set; }
        public int NoStaffs { get; set; }
        public bool PrivateFacility { get; set; }
        public int Level { get; set; }
    }
}
