using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class MedicalFacility
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacilityId { get; set; }
        [Required]
        public string FacilityName { get; set; }
        [Required]
        public int NoDoctors { get; set; }
        [Required]
        public int NoStaffs { get; set; }
        [Required]
        public bool PrivateFacility { get; set; }
        [Required]
        public int Level { get; set; }

    }
}
