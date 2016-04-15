using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string OrganizationStatus { get; set; }
        public string OrganizationType { get; set; }
        public string OrganizationDescription { get; set; }
        public string OrganizationAdress { get; set; }
        public string OrganizationEmail { get; set; }
        public string OrganizationPhoneNumbe { get; set; }
    }
}
