using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.DTOs
{
    public class ServicePriceListDTO
    {
        public int ServiceLevel { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
    }
}
