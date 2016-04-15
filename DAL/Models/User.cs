using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        public int IDUser { get; set; }
        public int OrganizationId { get; set; }
        public int PrivilegeId { get; set; }
        public int CityId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserMiddleName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserMobilePhoneNumber { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<System.DateTime> ActivatedDate { get; set; }
        public string ActivatedLink { get; set; }
        public Nullable<System.DateTime> LastVisitDate { get; set; }
        public string AvatarPath { get; set; }
        public System.DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
