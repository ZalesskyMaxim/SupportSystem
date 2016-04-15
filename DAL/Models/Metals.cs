using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Metals
    {
        public int MetalId { get; set; }
        public int MaterialId { get; set; }
        public string MetalName { get; set; }
        public string MetalRemark { get; set; }
    }
}
