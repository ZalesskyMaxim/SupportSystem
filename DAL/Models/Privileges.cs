using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Privileges
    {
        public int PrivilegeId { get; set; }
        public Nullable<int> Privilege { get; set; }
        public string PrivilegeDescription { get; set; }
    }
}
