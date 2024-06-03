using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class ServicePriceList
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ServiceId { get; set; }
        [Required]

        public int ServiceLevel { get; set; }
        [Required]

        public string ServiceName { get; set; }
        [Required]

        public decimal ServicePrice { get; set; }

    }
}
