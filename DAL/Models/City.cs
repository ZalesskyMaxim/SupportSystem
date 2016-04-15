using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string UserCity { get; set; }
        public string Country { get; set; }
        public string AdministrativeDevision { get; set; }
        public string Region { get; set; }
    }
}
