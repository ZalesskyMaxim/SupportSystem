using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class GeografyPlace
    {
        public int GeografyPlaceId { get; set; }
        public int CountryId { get; set; }
        public string GeografyPlaceCity { get; set; }
        public string Administrative_District_1 { get; set; }
        public string Administrative_District_2 { get; set; }
        public string Administrative_District_3 { get; set; }
    }
}
