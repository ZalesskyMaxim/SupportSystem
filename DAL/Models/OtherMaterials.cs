using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OtherMaterials
    {
        public int OtherMaterialId { get; set; }
        public int MaterialId { get; set; }
        public string OtherMaterialName { get; set; }
        public string OtherMateriaRemark { get; set; }
    }
}
